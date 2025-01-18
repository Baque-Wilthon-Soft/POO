using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miproyecto1.Logica;
using Miproyecto1.Presentacion;

namespace Miproyecto1
{
    public partial class FrmUsuarios : Form
    {
        public bool modoEdision = false;
        public int id = 0;

        public FrmUsuarios(string modo)
        {
            InitializeComponent();
            if (modo != "n")
            {
                this.modoEdision = true;
                this.id = int.Parse(modo);
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cargapais();
            if (!this.modoEdision)
            {
                lblTitulo.Text = "Ingreso de Nuevo Usuario";
            }
            else
            {
                lblTitulo.Text = "Actualización de Usuario";
                var clsUsuarios = new cls_usuarios();
                var usuario = clsUsuarios.uno(this.id);
                txtCédula.Text = usuario.cedula;
                txtNombre.Text = usuario.nombre;
                txtApellido.Text = usuario.apellido;
                txtCargo.Text = usuario.cargo;
                txtEmail.Text = usuario.email;
                cmbPais.SelectedValue = usuario.idPais;
            }
        }

        public void cargapais()
        {
            var listapaises = new cls_pais();
            cmbPais.DataSource = listapaises.leer();
            cmbPais.ValueMember = "IdPais";
            cmbPais.DisplayMember = "Detalle";
        }

        private void txtCédula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtCédula.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtCargo.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Por favor, complete los campos");
                return;
            }

            var dtoUsuario = new Datos.dto_usuarios
            {
                cedula = txtCédula.Text,
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                cargo = txtCargo.Text,
                email = txtEmail.Text,
                idPais = (int)cmbPais.SelectedValue
            };

            var clsUsuarios = new cls_usuarios();

            try
            {
                if (!this.modoEdision)
                {
                    var valorInsertar = clsUsuarios.Insertar(dtoUsuario);
                    if (valorInsertar == "ok")
                    {
                        MessageBox.Show("Usuario registrado con éxito");
                        this.Close();
                    }
                }
                else
                {
                    dtoUsuario.idUsuario = this.id;
                    if (clsUsuarios.actualizar(dtoUsuario) == "ok")
                    {
                        MessageBox.Show("Usuario actualizado con éxito");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCédula_Leave(object sender, EventArgs e)
        {
            if (this.modoEdision) return;

            var clsUsuarios = new cls_usuarios();
            if (clsUsuarios.duplicadoCedula(txtCédula.Text))
            {
                txtCédula.Focus();
                MessageBox.Show("El número ingresado ya fue registrado");
                borrar();
            }
        }

        public void borrar()
        {
            txtCédula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCargo.Text = "";
            txtEmail.Text = "";
            cmbPais.SelectedIndex = 0;
        }

        private void cmbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPais_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
