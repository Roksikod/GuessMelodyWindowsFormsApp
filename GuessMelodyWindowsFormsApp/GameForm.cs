using System;
using System.Windows.Forms;

namespace GuessMelodyWindowsFormsApp
{
    public partial class GameForm : Form
    {
        Random random = new Random();
        int musicDuration = Game.musicDuration;

        public GameForm()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Game.gameList.Count == 0)
            {
                EndGame();
            }
            else
            {
                musicDuration = Game.musicDuration;
                int numberSong = random.Next(0, Game.gameList.Count);
                winMediaPlayer.URL = Game.gameList[numberSong];
                //winMediaPlayer.Ctlcontrols.play();
                Game.gameList.RemoveAt(numberSong);
                countMelodyLabel.Text = Game.gameList.Count.ToString();
            }
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
            musicDurationLabel.Text = musicDuration.ToString();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EndGame();
        }

        private void EndGame()
        {
            timer.Stop();
            winMediaPlayer.Ctlcontrols.stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;
            musicDuration--;
            musicDurationLabel.Text = musicDuration.ToString();

            if (progressBar.Value == progressBar.Maximum)
            {
                EndGame();
                return;
            }
            if(musicDuration == 0)
            {
                MakeMusic();
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
            MessageForm messageForm = new MessageForm();

            if (e.KeyData == Keys.A)
            {
                GamePause();
                messageForm.messageLabel.Text = "Spieler 1";

                if (messageForm.ShowDialog() == DialogResult.Yes)
                {
                    counter1Label.Text = Convert.ToString(Convert.ToInt32(counter1Label.Text) + 1);
                    MakeMusic();
                }

                GamePlay();
            }

            //for the second player
            if (e.KeyData == Keys.P)
            {
                GamePause();
                messageForm.messageLabel.Text = "Spieler 2";

                if (messageForm.ShowDialog() == DialogResult.Yes)
                {
                    counter2Label.Text = Convert.ToString(Convert.ToInt32(counter2Label.Text) + 1);
                    MakeMusic();
                }

                GamePlay();
            }
        }

        private void winMediaPlayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Game.randomStart)
            {
                if (winMediaPlayer.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    winMediaPlayer.Ctlcontrols.currentPosition = random.Next(0, (int)winMediaPlayer.currentMedia.duration / 2);
                }
            }
        }
    }
}
