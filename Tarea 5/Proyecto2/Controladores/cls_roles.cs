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
    class cls_roles
    {
        private dto_roles roles_Model = new dto_roles();
        private readonly conexion cn = new conexion();
        public List<dto_roles> todos()
        {
            var listaRoles = new List<dto_roles>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "select * from roles";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var rol = new dto_roles
                            {
                                Detalle = lector["Detalle"].ToString(),
                                Rol_Id = (int)lector["Rol_Id"]
                            };
                            listaRoles.Add(rol);
                        }
                    }
                }
            }
            return listaRoles;
        }
    }
}
