namespace pubssemana3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FormuTitulos formuTitulos = new Formularios.FormuTitulos();
            formuTitulos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FormuAutor formuAutor = new Formularios.FormuAutor();
            formuAutor.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FormuEmpleado formuEmpleado = new Formularios.FormuEmpleado();
            formuEmpleado.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FormuPublicador formuPublicador = new Formularios.FormuPublicador();
            formuPublicador.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formularios.FormuVentas formuVentas = new Formularios.FormuVentas();
            formuVentas.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formularios.FormuTiendas formuTiendas = new Formularios.FormuTiendas();
            formuTiendas.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formularios.FormuDescuento formuDescuento = new Formularios.FormuDescuento();
            formuDescuento.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formularios.FormuAutorTitulo formuAutorTitulo = new Formularios.FormuAutorTitulo();
            formuAutorTitulo.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formularios.FormuRegalia formuRegalia = new Formularios.FormuRegalia();
            formuRegalia.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formularios.FormuPublicadorInfo formuPublicadorInfo = new Formularios.FormuPublicadorInfo();
            formuPublicadorInfo.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formularios.FormuTrabajos formuTrabajos = new Formularios.FormuTrabajos();
            formuTrabajos.ShowDialog();
        }
    }
}
