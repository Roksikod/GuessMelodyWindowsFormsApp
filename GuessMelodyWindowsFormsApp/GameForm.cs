using System;
using System.Windows.Forms;

namespace GuessMelodyWindowsFormsApp
{
    public partial class GameForm : Form
    {
        Random random = new Random();

        public GameForm()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            int numberSong = random.Next(0, Game.gameList.Count);
            winMediaPlayer.URL = Game.gameList[numberSong];
            //winMediaPlayer.Ctlcontrols.play();
            Game.gameList.RemoveAt(numberSong);


        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            MakeMusic();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            winMediaPlayer.Ctlcontrols.stop();

        }
    }
}
