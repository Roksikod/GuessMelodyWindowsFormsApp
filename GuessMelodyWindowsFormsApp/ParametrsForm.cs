using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelodyWindowsFormsApp
{
    public partial class ParametrsForm : Form
    {
        public ParametrsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //select & download music
                string[] listMusic = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.mp3", allDirectoryCheckBox.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                musicListBox.Items.Clear();
                musicListBox.Items.AddRange(listMusic);

                Game.gameList.Clear();
                Game.gameList.AddRange(listMusic);
            }


        }

        private void musicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
