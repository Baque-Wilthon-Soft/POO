using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto2.Controladores;

namespace Proyecto2
{
    public partial class FrmLogin : Form
    {
        private cls_cuenta cuentas_accesos = new cls_cuenta();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var usuario = cuentas_accesos.login(txtuser.Text.Trim(), txtpass.Text.Trim());
            if (usuario.Detalle_Rol == null)
            {
                MessageBox.Show("El usuario o la contrasenia son incorrectos");
            }
            else
            {
                MessageBox.Show("Ingreso existoso");

            }
        }
    }
}
