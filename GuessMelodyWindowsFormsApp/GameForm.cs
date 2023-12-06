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
            countMelodyLabel.Text = Game.gameList.Count.ToString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            MakeMusic();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            countMelodyLabel.Text = Game.gameList.Count.ToString();
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = Game.gameDuration;
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            winMediaPlayer.Ctlcontrols.stop();
        }
       
        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;

            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Stop();
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            winMediaPlayer.Ctlcontrols.pause();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            winMediaPlayer.Ctlcontrols.play();
        }
    }
}
