using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaSemana6
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adventureWorks2017DataSet.listaEmpleadosConEstado' Puede moverla o quitarla según sea necesario.
            this.listaEmpleadosConEstadoTableAdapter.Fill(this.adventureWorks2017DataSet.listaEmpleadosConEstado);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.listaEmpleadosConEstadoTableAdapter.FillByJobtittle(this.adventureWorks2017DataSet.listaEmpleadosConEstado, txtBuscar.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
