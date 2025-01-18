using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miproyecto1.Presentación;

namespace Miproyecto1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUPersonal cupersonal = new CUPersonal();
            panelgeneral.Controls.Clear();
            cupersonal.Dock = DockStyle.Fill;
            panelgeneral.Controls.Add(cupersonal);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentacion.Asistencias.frmAsistencias frmAsistencias = new Presentacion.Asistencias.frmAsistencias();
            frmAsistencias.ShowDialog();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CUUsuarios cuusuarios = new CUUsuarios();
            panelgeneral.Controls.Clear();
            cuusuarios.Dock = DockStyle.Fill;
            panelgeneral.Controls.Add(cuusuarios);
        }
    }
}
