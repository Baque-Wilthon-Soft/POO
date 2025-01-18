using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2.Config;
using Proyecto2.Modelos;

namespace Proyecto2.Controladores
{
    class cls_cuenta
    {
        private dto_usuario usuario_Model = new dto_usuario();
        private readonly conexion cn = new conexion();
        public dto_usuario login(string Username, string Password)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"select * from Usuarios " +
                $"inner join Roles on Usuarios.Roles_id = Roles.Rol_Id " +
                $"where Usuarios.Username = '{Username}'";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            if (Password == lector["Password"].ToString())
                            {
                                return new dto_usuario
                                {
                                    Id_User = (int)lector["Id_User"],
                                    Username = lector["Username"].ToString(),
                                    Password = lector["Password"].ToString(),
                                    Roles_id = (int)lector["Roles_id"],
                                    Detalle_Rol = lector["Detalle"].ToString(),
                                };
                            }
                            else
                            {
                                return new dto_usuario();
                            }
                        }
                        else
                        {
                            return new dto_usuario();
                        }

                    }
                }
            }
        }
    }
}
