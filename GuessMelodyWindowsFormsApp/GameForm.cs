using System;
using System.Windows.Forms;

namespace GuessMelodyWindowsFormsApp
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            winMediaPlayer.URL = Game.gameList[0]; 
        }
    }
}
