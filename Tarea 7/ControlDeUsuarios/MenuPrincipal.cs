using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeUsuarios.Vista.Libros;
using ControlDeUsuarios.Vista.Login;
using ControlDeUsuarios.Vista.Prestamos;
using ControlDeUsuarios.Vista.Registro;
using ControlDeUsuarios.Vista.UsuariosLib;

namespace ControlDeUsuarios
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CURegistro curegistro = new CURegistro();
            panel.Controls.Clear();
            curegistro.Dock = DockStyle.Fill;
            panel.Controls.Add(curegistro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login culogin = new Login();
            panel.Controls.Clear();
            culogin.Dock = DockStyle.Fill;
            panel.Controls.Add(culogin);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CUUsuariosLib cuusuarios = new CUUsuariosLib();
            panel.Controls.Clear();
            cuusuarios.Dock = DockStyle.Fill;
            panel.Controls.Add(cuusuarios);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CULibros culib = new CULibros();
            panel.Controls.Clear();
            culib.Dock = DockStyle.Fill;
            panel.Controls.Add(culib);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CUPrestamos cuprestamos = new CUPrestamos();
            panel.Controls.Clear();
            cuprestamos.Dock = DockStyle.Fill;
            panel.Controls.Add(cuprestamos);
        }
    }
}
