using System;
using System.Windows.Forms;

namespace GuessMelodyWindowsFormsApp
{
    public partial class MainForm : Form
    {
        ParametrsForm frm = new ParametrsForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void parametrsButton_Click(object sender, EventArgs e)
        {            
            frm.ShowDialog();
        }
    }
}
