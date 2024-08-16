namespace EjemploExploracion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            int valorObtenidoTextBox1 = int.Parse(this.textValor1.Text);
            int valorObtenidoTextBox2 = int.Parse(this.textValor2.Text);

            int resultadoSuma = valorObtenidoTextBox1 + valorObtenidoTextBox2;
            this.resultOperacion.Text = $"Resultado: {resultadoSuma.ToString()}";

            this.listBox1.Items.Add($"Resultado: {resultadoSuma.ToString()}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultOperacion_Click(object sender, EventArgs e)
        {

        }
    }
}
