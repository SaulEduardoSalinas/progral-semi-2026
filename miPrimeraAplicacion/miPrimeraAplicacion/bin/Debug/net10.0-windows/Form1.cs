namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        private double lblnum1;
        private double num1;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            double nun1, num2, resultado;
            num1 = Double.Parse(txtNum1.Text); //txtNum1.Text > cadena= "5" => 5.0
            num2 = Double.Parse(txtNum2.Text);

            resultado = num1 + num2;

            lblRespuesta.Text = "Respuesta : " + resultado.ToString();
        }
    }
}

