using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miproyecto1.Datos
{
    internal class dto_usuarios
    {
        public int idUsuario { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido{ get; set; }
        public string cargo { get; set; }
        public int idPais { get; set; }
        public string email { get; set; }
    }
}
