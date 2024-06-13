using System;
using System.Windows.Forms;


namespace P0005
{
    public partial class FormA : Form
    {
        public FormA()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button on FormA clicked...");
        }
    }
}
