namespace DesignTest03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SalidaLabel.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumeradortextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DividirButton_Click_Click(object sender, EventArgs e)
        {
            SalidaLabel.Text = "";

            try
            {
                float numerador = Convert.ToInt32(NumeradortextBox.Text);
                float denominador = Convert.ToInt32(DenominadortextBox.Text);
                float resultado = numerador / denominador;

                SalidaLabel.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Escribe dos pinches numeros enteros", "Formato de numero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException divideByZeroExceptionParameter)
            {
                MessageBox.Show(divideByZeroExceptionParameter.Message, "Eres un pendejo no se divide entre cero", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void SumaButton_Click(object sender, EventArgs e)
        {

            try
            {
                float n1 = Convert.ToInt32(NumeradortextBox.Text);
                float n2 = Convert.ToInt32(DenominadortextBox.Text);
                float n3 = n1 + n2;

                SalidaLabel.Text = n3.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Escribe dos pinches numeros enteros", "Formato de numero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RestaButton_Click(object sender, EventArgs e)
        {

            try
            {
                float m1 = Convert.ToInt32(NumeradortextBox.Text);
                float m2 = Convert.ToInt32(DenominadortextBox.Text);
                float m3 = m1 - m2;

                SalidaLabel.Text = m3.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Escribe dos pinches numeros enteros", "Formato de numero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MultiplicacionButton_Click(object sender, EventArgs e)
        {

            try
            {
                float o1 = Convert.ToInt32(NumeradortextBox.Text);
                float o2 = Convert.ToInt32(DenominadortextBox.Text);
                float o3 = o1 * o2;

                SalidaLabel.Text = o3.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Escribe dos pinches numeros enteros", "Formato de numero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
