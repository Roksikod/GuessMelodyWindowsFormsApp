using System;
using System.IO;
using System.Windows.Forms;

namespace GuessMelodyWindowsFormsApp
{
    public partial class ParametrsForm : Form
    {
        public ParametrsForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Game.allDirectories = allDirectoryCheckBox.Checked;
            Game.gameDuration = Convert.ToInt32(gameDurationComboBox.Text);
            Game.musicDuration = Convert.ToInt32(musicDurationComboBox.Text);
            Game.randomStart = randomStartCheckBox.Checked;
            Game.WriteParametrs();
            this.Close();
        }        

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //select & download music
                string[] listMusic = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.mp3", allDirectoryCheckBox.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                Game.lastFolder = folderBrowserDialog.SelectedPath;
                musicListBox.Items.Clear();
                musicListBox.Items.AddRange(listMusic);

                Game.gameList.Clear();
                Game.gameList.AddRange(listMusic);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            SetParametrs();
            this.Close();
        }

        private void SetParametrs()
        {
            allDirectoryCheckBox.Checked = Game.allDirectories;
            gameDurationComboBox.Text = Game.gameDuration.ToString();
            musicDurationComboBox.Text = Game.musicDuration.ToString();
            randomStartCheckBox.Checked = Game.randomStart;
        }

        private void ParametrsForm_Load(object sender, EventArgs e)
        {
            SetParametrs();
            musicListBox.Items.Clear();
            musicListBox.Items.AddRange(Game.gameList.ToArray());
        }
    }
}
