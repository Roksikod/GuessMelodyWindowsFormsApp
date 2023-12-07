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
            winMediaPlayer.Ctlcontrols.play();
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
            GamePause();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        private void GamePlay()
        {
            timer.Start();
            winMediaPlayer.Ctlcontrols.play();
        }

        private void GamePause()
        {
            timer.Stop();
            winMediaPlayer.Ctlcontrols.pause();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.A)
            {
                GamePause();

                if(MessageBox.Show("Erraten?", "Spieler 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    counter1Label.Text = Convert.ToString(Convert.ToInt32(counter1Label.Text)+1);
                    MakeMusic();
                }

                GamePlay();
            }

            //for the second player
            if (e.KeyData == Keys.P)
            {
                GamePause();

                if (MessageBox.Show("Erraten?", "Spieler 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    counter2Label.Text = Convert.ToString(Convert.ToInt32(counter2Label.Text) + 1);
                    MakeMusic();
                }

                GamePlay();
            }
        }
    }
}
