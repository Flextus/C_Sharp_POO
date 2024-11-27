namespace FormsTest_04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Cargar1Button = new Button();
            pictureBox1 = new PictureBox();
            Cargar2Button = new Button();
            BorrarButtton = new Button();
            Cargar3Button = new Button();
            CargarButton = new Button();
            Edad = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(232, 25);
            label1.TabIndex = 1;
            label1.Text = "Vamos a cargar una imagen";
            label1.Click += label1_Click;
            // 
            // Cargar1Button
            // 
            Cargar1Button.Location = new Point(0, 0);
            Cargar1Button.Name = "Cargar1Button";
            Cargar1Button.Size = new Size(75, 23);
            Cargar1Button.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(382, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Cargar2Button
            // 
            Cargar2Button.Location = new Point(72, 275);
            Cargar2Button.Name = "Cargar2Button";
            Cargar2Button.Size = new Size(112, 34);
            Cargar2Button.TabIndex = 6;
            Cargar2Button.Text = "Cargar (2)";
            Cargar2Button.UseVisualStyleBackColor = true;
            // 
            // BorrarButtton
            // 
            BorrarButtton.Location = new Point(72, 395);
            BorrarButtton.Name = "BorrarButtton";
            BorrarButtton.Size = new Size(112, 34);
            BorrarButtton.TabIndex = 5;
            BorrarButtton.Text = "Borrar";
            BorrarButtton.UseVisualStyleBackColor = true;
            BorrarButtton.Click += BorrarButtton_Click;
            // 
            // Cargar3Button
            // 
            Cargar3Button.Location = new Point(72, 315);
            Cargar3Button.Name = "Cargar3Button";
            Cargar3Button.Size = new Size(112, 34);
            Cargar3Button.TabIndex = 7;
            Cargar3Button.Text = "Cargar (3)";
            Cargar3Button.UseVisualStyleBackColor = true;
            // 
            // CargarButton
            // 
            CargarButton.Location = new Point(72, 235);
            CargarButton.Name = "CargarButton";
            CargarButton.Size = new Size(112, 34);
            CargarButton.TabIndex = 9;
            CargarButton.Text = "Cargar (1)";
            CargarButton.UseVisualStyleBackColor = true;
            CargarButton.Click += CargarButton_Click;
            // 
            // Edad
            // 
            Edad.Location = new Point(72, 355);
            Edad.Name = "Edad";
            Edad.Size = new Size(112, 34);
            Edad.TabIndex = 10;
            Edad.Text = "Edad";
            Edad.UseVisualStyleBackColor = true;
            Edad.Click += Edad_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(51, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 508);
            Controls.Add(textBox1);
            Controls.Add(Edad);
            Controls.Add(CargarButton);
            Controls.Add(Cargar3Button);
            Controls.Add(Cargar2Button);
            Controls.Add(BorrarButtton);
            Controls.Add(pictureBox1);
            Controls.Add(Cargar1Button);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button Cargar1Button;
        private PictureBox pictureBox1;
        private Button Cargar2Button;
        private Button BorrarButtton;
        private Button Cargar3Button;
        private Button CargarButton;
        private Button Edad;
        private TextBox textBox1;
    }
}
