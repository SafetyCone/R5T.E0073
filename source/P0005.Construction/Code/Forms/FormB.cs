using System;
using System.Windows.Forms;


namespace P0005.Construction
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var formA = new FormA();

            formA.ShowDialog(this);
        }
    }
}
