
namespace ExercícioTPAula02
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmIMC_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(txbPeso.Text);
            altura = Convert.ToDouble(txbAltura.Text);
           
            var (descriçãoIMC,resultadoIMC) =  CalcularIMC(peso, altura/100);

            lblResult.Text = $"{descriçãoIMC}\nSeu IMC: {resultadoIMC:F2}";
        }

        private (string,double) CalcularIMC(double peso, double altura)
        {
            double imc = peso / Math.Pow(altura, 2);

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };
            return (resultado,imc);
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbPeso.Clear();
            txbAltura.Clear();
            lblResult.Text = "";
            txbPeso.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblSistemaIMC_Click(object sender, EventArgs e)
        {

        }
    }
}