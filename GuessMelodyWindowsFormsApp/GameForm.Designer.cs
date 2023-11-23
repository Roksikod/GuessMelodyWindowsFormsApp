namespace GuessMelodyWindowsFormsApp
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.winMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.winMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // winMediaPlayer
            // 
            this.winMediaPlayer.Enabled = true;
            this.winMediaPlayer.Location = new System.Drawing.Point(129, 276);
            this.winMediaPlayer.Name = "winMediaPlayer";
            this.winMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winMediaPlayer.OcxState")));
            this.winMediaPlayer.Size = new System.Drawing.Size(247, 61);
            this.winMediaPlayer.TabIndex = 0;
            this.winMediaPlayer.Visible = false;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(655, 21);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(215, 78);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Nächste";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelodyWindowsFormsApp.Properties.Resources.melodiBild;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.winMediaPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "Musik Spiel!";
            ((System.ComponentModel.ISupportInitialize)(this.winMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer winMediaPlayer;
        private System.Windows.Forms.Button nextButton;
    }
}