using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2.Config;
using Proyecto2.Modelos;

namespace Proyecto2.Controladores
{
    class cls_usuarios
    {
        private dto_usuario usuario_Model = new dto_usuario();
        private readonly conexion cn = new conexion();
        public List<dto_usuario> todos() { return null; }
        public dto_usuario uno(int Id_User) { return null; }
        public string insertar(dto_usuario usuario) { return "ok"; }
        public string actualizar(dto_usuario usuario) { return "ok"; }
        public string eliminar(int Id_User) { return "ok"; }
    }
}
