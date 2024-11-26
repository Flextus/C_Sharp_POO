using System;

namespace userb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            SalidaLabel.Text = "";

            try
            {
                int numerador = Convert.ToInt32(NumeradorTextBox.Text);
                int denominador = Convert.ToInt32(DenominadorTextBox.Text);

                int resultado = numerador / denominador;

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
    }
}