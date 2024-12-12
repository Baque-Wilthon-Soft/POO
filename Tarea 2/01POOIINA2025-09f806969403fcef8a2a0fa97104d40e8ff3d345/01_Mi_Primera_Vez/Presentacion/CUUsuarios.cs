using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class CUUsuarios : UserControl
    {
        public CUUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Presentacion.FormuUsuario cUUsuarios = new Presentacion.FormuUsuario();
            cUUsuarios.Show();
        }
    }
}
