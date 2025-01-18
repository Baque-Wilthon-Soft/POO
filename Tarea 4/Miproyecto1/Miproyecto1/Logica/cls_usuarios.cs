using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Miproyecto1.Datos;
using System.Globalization;

namespace Miproyecto1.Logica
{
    internal class cls_usuarios
    {
        private readonly conexion cn = new conexion();

        public string Insertar(dto_usuarios Usuario)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena1 = "insert into usuarios (cedula, nombre, apellido, cargo, idPais, email) values ('" +
                    Usuario.cedula + "','" +
                    Usuario.nombre + "','" +
                    Usuario.apellido + "','" +
                    Usuario.cargo + "'," +
                    Usuario.idPais + ",'" +
                    Usuario.email + "')";
                using (var comando = new SqlCommand(cadena1, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
        }

        public List<dto_usuarios> todos()
        {
            var listaUsuarios = new List<dto_usuarios>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT idUsuario, cedula, nombre, apellido, cargo, Paises.IdPais, Paises.Detalle, email " +
                    "FROM usuarios INNER JOIN Paises ON Paises.IdPais = usuarios.idPais";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var usuario = new dto_usuarios
                            {
                                idUsuario = (int)lector["idUsuario"],
                                cedula = lector["cedula"].ToString(),
                                nombre = lector["nombre"].ToString(),
                                apellido = lector["apellido"].ToString(),
                                cargo = lector["cargo"].ToString(),
                                idPais = (int)lector["IdPais"],
                                email = lector["email"].ToString()
                            };
                            listaUsuarios.Add(usuario);
                        }
                    }
                }
            }

            return listaUsuarios;
        }

        public dto_usuarios uno(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM usuarios WHERE idUsuario=" + id;
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();
                        var usuario = new dto_usuarios
                        {
                            idUsuario = (int)lector["idUsuario"],
                            cedula = lector["cedula"].ToString(),
                            nombre = lector["nombre"].ToString(),
                            apellido = lector["apellido"].ToString(),
                            cargo = lector["cargo"].ToString(),
                            idPais = (int)lector["idPais"],
                            email = lector["email"].ToString()
                        };
                        return usuario;
                    }
                }
            }
        }

        public dto_usuarios uno(string cedula)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT * FROM usuarios WHERE cedula='{cedula}'";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            var usuario = new dto_usuarios
                            {
                                idUsuario = (int)lector["idUsuario"],
                                cedula = lector["cedula"].ToString(),
                                nombre = lector["nombre"].ToString(),
                                apellido = lector["apellido"].ToString(),
                                cargo = lector["cargo"].ToString(),
                                idPais = (int)lector["idPais"],
                                email = lector["email"].ToString()
                            };
                            return usuario;
                        }
                        else
                        {
                            return new dto_usuarios();
                        }
                    }
                }
            }
        }

        public string actualizar(dto_usuarios usuario)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "UPDATE usuarios SET " +
                    $"cedula='{usuario.cedula}', nombre='{usuario.nombre}', apellido='{usuario.apellido}', " +
                    $"cargo='{usuario.cargo}', idPais={usuario.idPais}, email='{usuario.email}' " +
                    $"WHERE idUsuario={usuario.idUsuario}";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
        }

        public bool duplicadoCedula(string cedula)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT COUNT(*) AS repetidos FROM usuarios WHERE cedula='{cedula}'";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();
                        return (int)lector["repetidos"] > 0;
                    }
                }
            }
        }

        public bool eliminar(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"DELETE FROM usuarios WHERE idUsuario={id}";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }

        public List<dto_usuarios> buscador(string texto)
        {
            List<dto_usuarios> listaUsuarios = new List<dto_usuarios>();

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT idUsuario, cedula, nombre, apellido, cargo, Paises.IdPais, Paises.Detalle, email " +
                    "FROM usuarios INNER JOIN Paises ON Paises.IdPais = usuarios.idPais " +
                    $"WHERE nombre LIKE '%{texto}%' OR apellido LIKE '%{texto}%'";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var usuario = new dto_usuarios
                            {
                                idUsuario = (int)lector["idUsuario"],
                                cedula = lector["cedula"].ToString(),
                                nombre = lector["nombre"].ToString(),
                                apellido = lector["apellido"].ToString(),
                                cargo = lector["cargo"].ToString(),
                                idPais = (int)lector["IdPais"],
                                email = lector["email"].ToString()
                            };
                            listaUsuarios.Add(usuario);
                        }
                    }
                }
            }

            return listaUsuarios;
        }
    }
}