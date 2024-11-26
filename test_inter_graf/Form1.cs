using System;
using System.Windows.Forms;

namespace PruebaDivisionEntreCero
{
    public partial class DivisionEntreCero : Form
    {
        public DivisionEntreCero() 
        {
            InitializeComponent();
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            SalidaLabel.Text = "";
        }
        
    }
}