namespace DesignTest03
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
            label2 = new Label();
            SalidaLabel = new Label();
            NumeradortextBox = new TextBox();
            DenominadortextBox = new TextBox();
            DividirButton_Click = new Button();
            SumaButton = new Button();
            RestaButton = new Button();
            MultiplicacionButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 153);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "Escriba el Primer Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 248);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 1;
            label2.Text = "Escriba el Segundo Numero";
            label2.Click += label2_Click;
            // 
            // SalidaLabel
            // 
            SalidaLabel.AutoSize = true;
            SalidaLabel.Location = new Point(396, 439);
            SalidaLabel.Name = "SalidaLabel";
            SalidaLabel.Size = new Size(90, 25);
            SalidaLabel.TabIndex = 2;
            SalidaLabel.Text = "Resultado";
            SalidaLabel.Click += label3_Click;
            // 
            // NumeradortextBox
            // 
            NumeradortextBox.Location = new Point(361, 150);
            NumeradortextBox.Name = "NumeradortextBox";
            NumeradortextBox.Size = new Size(159, 31);
            NumeradortextBox.TabIndex = 3;
            NumeradortextBox.TextChanged += NumeradortextBox_TextChanged;
            // 
            // DenominadortextBox
            // 
            DenominadortextBox.Location = new Point(361, 245);
            DenominadortextBox.Name = "DenominadortextBox";
            DenominadortextBox.Size = new Size(159, 31);
            DenominadortextBox.TabIndex = 4;
            // 
            // DividirButton_Click
            // 
            DividirButton_Click.Location = new Point(163, 523);
            DividirButton_Click.Name = "DividirButton_Click";
            DividirButton_Click.Size = new Size(112, 34);
            DividirButton_Click.TabIndex = 5;
            DividirButton_Click.Text = "DIVIDIR";
            DividirButton_Click.UseVisualStyleBackColor = true;
            DividirButton_Click.Click += DividirButton_Click_Click;
            // 
            // SumaButton
            // 
            SumaButton.Location = new Point(163, 333);
            SumaButton.Name = "SumaButton";
            SumaButton.Size = new Size(112, 34);
            SumaButton.TabIndex = 6;
            SumaButton.Text = "SUMA";
            SumaButton.UseVisualStyleBackColor = true;
            SumaButton.Click += SumaButton_Click;
            // 
            // RestaButton
            // 
            RestaButton.Location = new Point(163, 401);
            RestaButton.Name = "RestaButton";
            RestaButton.Size = new Size(112, 34);
            RestaButton.TabIndex = 7;
            RestaButton.Text = "RESTA";
            RestaButton.UseVisualStyleBackColor = true;
            RestaButton.Click += RestaButton_Click;
            // 
            // MultiplicacionButton
            // 
            MultiplicacionButton.Location = new Point(163, 465);
            MultiplicacionButton.Name = "MultiplicacionButton";
            MultiplicacionButton.Size = new Size(112, 34);
            MultiplicacionButton.TabIndex = 8;
            MultiplicacionButton.Text = "MULTI";
            MultiplicacionButton.UseVisualStyleBackColor = true;
            MultiplicacionButton.Click += MultiplicacionButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 661);
            Controls.Add(MultiplicacionButton);
            Controls.Add(RestaButton);
            Controls.Add(SumaButton);
            Controls.Add(DividirButton_Click);
            Controls.Add(DenominadortextBox);
            Controls.Add(NumeradortextBox);
            Controls.Add(SalidaLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label SalidaLabel;
        private TextBox NumeradortextBox;
        private TextBox DenominadortextBox;
        private Button DividirButton_Click;
        private Button SumaButton;
        private Button RestaButton;
        private Button MultiplicacionButton;
    }
}
