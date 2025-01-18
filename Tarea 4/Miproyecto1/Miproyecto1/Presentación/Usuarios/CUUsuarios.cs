using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Miproyecto1.Logica;

namespace Miproyecto1
{
    public partial class CUUsuarios : UserControl
    {
        public CUUsuarios()
        {
            InitializeComponent();
        }

        private void CUUsuarios_Load(object sender, EventArgs e)
        {
            this.cargaGrilla(1);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios("n");
            frmUsuarios.Text = "Nuevo Usuario";
            frmUsuarios.ShowDialog();
            this.cargaGrilla(1);
        }

        public void cargaGrilla(int tipo)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            var logicaUsuarios = new cls_usuarios();

            var colAutoIncremento = new DataGridViewTextBoxColumn
            {
                HeaderText = "N°",
                ReadOnly = true
            };
            dataGridView1.Columns.Add(colAutoIncremento);

            var btnEditar = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };

            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            if (tipo == 1)
                dataGridView1.DataSource = logicaUsuarios.todos();
            else
                dataGridView1.DataSource = logicaUsuarios.buscador(txtBuscar.Text.Trim());

            dataGridView1.Columns["cedula"].HeaderText = "Cédula";
            dataGridView1.Columns["nombre"].HeaderText = "Nombre";
            dataGridView1.Columns["apellido"].HeaderText = "Apellido";
            dataGridView1.Columns["cargo"].HeaderText = "Cargo";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["idUsuario"].Visible = false;
            dataGridView1.Columns["idPais"].Visible = false;

            dataGridView1.Columns.Add(btnEditar);
            dataGridView1.Columns.Add(btnEliminar);

            // Suscribir al evento DataBindingComplete
            dataGridView1.DataBindingComplete -= DataGridView1_DataBindingComplete; // Evitar duplicaciones
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1; // Numerar las filas
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                var idUsuario = (int)filaSeleccionada.Cells["idUsuario"].Value;

                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    EditarUsuario(idUsuario);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    EliminarUsuario(idUsuario);
                }
            }
        }

        public void EditarUsuario(int id)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios(id.ToString());
            frmUsuarios.ShowDialog();
            this.cargaGrilla(1);
        }

        public void EliminarUsuario(int id)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                var logicaUsuarios = new cls_usuarios();
                if (logicaUsuarios.eliminar(id))
                {
                    MessageBox.Show("Usuario eliminado con éxito.");
                    this.cargaGrilla(1);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar el usuario.");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.cargaGrilla(2);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.cargaGrilla(2);
        }
    }
}
