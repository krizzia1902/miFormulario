namespace miFormulario
{
    public partial class tx : Form
    {
        public tx()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textAPELLIDO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlACEPTAR_Click(object sender, EventArgs e)
        {
            lblApellidoNombre.Text = txb.lblApellido .text + txbNombre;
        }
    }
}