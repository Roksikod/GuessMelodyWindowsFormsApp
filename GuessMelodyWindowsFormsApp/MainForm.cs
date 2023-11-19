using System;
using System.Windows.Forms;

namespace GuessMelodyWindowsFormsApp
{
    public partial class MainForm : Form
    {
        ParametrsForm parametrsForm = new ParametrsForm();
        GameForm gameForm = new GameForm();

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
            parametrsForm.ShowDialog();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            gameForm.ShowDialog();
        }
    }
}
