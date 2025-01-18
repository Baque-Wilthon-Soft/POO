using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Miproyecto1.Datos
{
    public class conexion
    {
        private readonly string varconexion = "Server=(local);database=Asistencias;uid=wilthongs;pwd=020905";
        public SqlConnection obtenerConexion(){
            return new SqlConnection(varconexion);
    }
    }
}
