using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendiente
{
    public partial class GestionTareasPendientes : Form
    {
        public GestionTareasPendientes()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                lstTareas.Items.Add(txtTarea.Text);
                txtTarea.Clear();
                txtTarea.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese una Tarea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                lstTareas.Items.Remove(lstTareas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione una Tarea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lstTareas.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
