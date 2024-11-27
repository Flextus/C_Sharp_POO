using FormsTest_04.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Metadata;

namespace FormsTest_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void BorrarButtton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void Cargar2Button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\benja\\OneDrive\\Documentos\\GitHub\\C_Sharp_POO\\FormsTest_04\\Resources\\a.png");
        }

        private void Cargar3Button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\benja\\OneDrive\\Documentos\\GitHub\\C_Sharp_POO\\FormsTest_04\\Resources\\b.png");
        }

        private void CargarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivos JPG (*.jpg; *.gif) | *.gif; *.jpg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(archivo.FileName);
            }
        }

        private void Edad_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = Convert.ToInt32(textBox1.Text);


                if (edad <= 10)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\benja\\OneDrive\\Documentos\\GitHub\\C_Sharp_POO\\FormsTest_04\\Resources\\1.png");
                }
                else if (edad >= 10 && edad < 20)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\benja\\OneDrive\\Documentos\\GitHub\\C_Sharp_POO\\FormsTest_04\\Resources\\2.png");
                }
                else if (edad >= 20 && edad < 30)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\benja\\OneDrive\\Documentos\\GitHub\\C_Sharp_POO\\FormsTest_04\\Resources\\3.jfif");
                }
                else if (edad >= 30 && edad < 40)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\benja\\OneDrive\\Documentos\\GitHub\\C_Sharp_POO\\FormsTest_04\\Resources\\4.jfif");
                }
                else if (edad >= 40 && edad < 50)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\benja\\OneDrive\\Documentos\\GitHub\\C_Sharp_POO\\FormsTest_04\\Resources\\5.png");
                }
                else if (edad >= 50 && edad < 60)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\benja\\OneDrive\\Documentos\\GitHub\\C_Sharp_POO\\FormsTest_04\\Resources\\6.jpg");
                }
                else if (edad >= 60)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\benja\\OneDrive\\Documentos\\GitHub\\C_Sharp_POO\\FormsTest_04\\Resources\\7.png");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Escribe una edad de Verdad", "Formato de numero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
