namespace GuessMelodyWindowsFormsApp
{
    partial class ParametrsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametrsForm));
            this.musicListBox = new System.Windows.Forms.ListBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.allDirectoryCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ParametrsGroupBox = new System.Windows.Forms.GroupBox();
            this.randomStartCheckBox = new System.Windows.Forms.CheckBox();
            this.musicDurationComboBox = new System.Windows.Forms.ComboBox();
            this.gameDurationComboBox = new System.Windows.Forms.ComboBox();
            this.musicDurationLabel = new System.Windows.Forms.Label();
            this.gameDurationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1ComboBox = new System.Windows.Forms.ComboBox();
            this.player2ComboBox = new System.Windows.Forms.ComboBox();
            this.ParametrsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicListBox
            // 
            this.musicListBox.FormattingEnabled = true;
            this.musicListBox.ItemHeight = 16;
            this.musicListBox.Location = new System.Drawing.Point(12, 6);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.Size = new System.Drawing.Size(862, 180);
            this.musicListBox.TabIndex = 0;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFolderButton.Location = new System.Drawing.Point(12, 205);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(180, 60);
            this.selectFolderButton.TabIndex = 1;
            this.selectFolderButton.Text = "Aussuchen";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearListButton.Location = new System.Drawing.Point(358, 205);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(180, 60);
            this.clearListButton.TabIndex = 2;
            this.clearListButton.Text = "Leeren";
            this.clearListButton.UseVisualStyleBackColor = true;
            // 
            // allDirectoryCheckBox
            // 
            this.allDirectoryCheckBox.AutoSize = true;
            this.allDirectoryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allDirectoryCheckBox.Location = new System.Drawing.Point(729, 205);
            this.allDirectoryCheckBox.Name = "allDirectoryCheckBox";
            this.allDirectoryCheckBox.Size = new System.Drawing.Size(131, 24);
            this.allDirectoryCheckBox.TabIndex = 3;
            this.allDirectoryCheckBox.Text = "Unterordner";
            this.allDirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(680, 388);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(180, 60);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(680, 481);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 60);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Stornierungen";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ParametrsGroupBox
            // 
            this.ParametrsGroupBox.Controls.Add(this.player2ComboBox);
            this.ParametrsGroupBox.Controls.Add(this.player1ComboBox);
            this.ParametrsGroupBox.Controls.Add(this.label2);
            this.ParametrsGroupBox.Controls.Add(this.label1);
            this.ParametrsGroupBox.Controls.Add(this.randomStartCheckBox);
            this.ParametrsGroupBox.Controls.Add(this.musicDurationComboBox);
            this.ParametrsGroupBox.Controls.Add(this.gameDurationComboBox);
            this.ParametrsGroupBox.Controls.Add(this.musicDurationLabel);
            this.ParametrsGroupBox.Controls.Add(this.gameDurationLabel);
            this.ParametrsGroupBox.Location = new System.Drawing.Point(12, 309);
            this.ParametrsGroupBox.Name = "ParametrsGroupBox";
            this.ParametrsGroupBox.Size = new System.Drawing.Size(634, 232);
            this.ParametrsGroupBox.TabIndex = 6;
            this.ParametrsGroupBox.TabStop = false;
            this.ParametrsGroupBox.Text = "Spieleinstellungen";
            // 
            // randomStartCheckBox
            // 
            this.randomStartCheckBox.AutoSize = true;
            this.randomStartCheckBox.Location = new System.Drawing.Point(10, 151);
            this.randomStartCheckBox.Name = "randomStartCheckBox";
            this.randomStartCheckBox.Size = new System.Drawing.Size(228, 20);
            this.randomStartCheckBox.TabIndex = 4;
            this.randomStartCheckBox.Text = "Von einer zufälligen Stelle im Lied";
            this.randomStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // musicDurationComboBox
            // 
            this.musicDurationComboBox.FormattingEnabled = true;
            this.musicDurationComboBox.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.musicDurationComboBox.Location = new System.Drawing.Point(113, 94);
            this.musicDurationComboBox.Name = "musicDurationComboBox";
            this.musicDurationComboBox.Size = new System.Drawing.Size(47, 24);
            this.musicDurationComboBox.TabIndex = 3;
            this.musicDurationComboBox.Text = "20";
            // 
            // gameDurationComboBox
            // 
            this.gameDurationComboBox.FormattingEnabled = true;
            this.gameDurationComboBox.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.gameDurationComboBox.Location = new System.Drawing.Point(113, 41);
            this.gameDurationComboBox.Name = "gameDurationComboBox";
            this.gameDurationComboBox.Size = new System.Drawing.Size(47, 24);
            this.gameDurationComboBox.TabIndex = 2;
            this.gameDurationComboBox.Text = "60";
            // 
            // musicDurationLabel
            // 
            this.musicDurationLabel.AutoSize = true;
            this.musicDurationLabel.Location = new System.Drawing.Point(7, 102);
            this.musicDurationLabel.Name = "musicDurationLabel";
            this.musicDurationLabel.Size = new System.Drawing.Size(97, 16);
            this.musicDurationLabel.TabIndex = 1;
            this.musicDurationLabel.Text = "Zeit vor Antwort";
            // 
            // gameDurationLabel
            // 
            this.gameDurationLabel.AutoSize = true;
            this.gameDurationLabel.Location = new System.Drawing.Point(7, 49);
            this.gameDurationLabel.Name = "gameDurationLabel";
            this.gameDurationLabel.Size = new System.Drawing.Size(73, 16);
            this.gameDurationLabel.TabIndex = 0;
            this.gameDurationLabel.Text = "Spieldauer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Spieler 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Spieler 2";
            // 
            // player1ComboBox
            // 
            this.player1ComboBox.FormattingEnabled = true;
            this.player1ComboBox.Location = new System.Drawing.Point(267, 41);
            this.player1ComboBox.Name = "player1ComboBox";
            this.player1ComboBox.Size = new System.Drawing.Size(60, 24);
            this.player1ComboBox.TabIndex = 8;
            this.player1ComboBox.Text = "A";
            // 
            // player2ComboBox
            // 
            this.player2ComboBox.FormattingEnabled = true;
            this.player2ComboBox.Location = new System.Drawing.Point(267, 94);
            this.player2ComboBox.Name = "player2ComboBox";
            this.player2ComboBox.Size = new System.Drawing.Size(60, 24);
            this.player2ComboBox.TabIndex = 9;
            this.player2ComboBox.Text = "P";
            // 
            // ParametrsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.ParametrsGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.allDirectoryCheckBox);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.musicListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParametrsForm";
            this.Text = "Regelung";
            this.Load += new System.EventHandler(this.ParametrsForm_Load);
            this.ParametrsGroupBox.ResumeLayout(false);
            this.ParametrsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox musicListBox;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.CheckBox allDirectoryCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox ParametrsGroupBox;
        private System.Windows.Forms.Label gameDurationLabel;
        private System.Windows.Forms.Label musicDurationLabel;
        private System.Windows.Forms.ComboBox musicDurationComboBox;
        private System.Windows.Forms.ComboBox gameDurationComboBox;
        private System.Windows.Forms.CheckBox randomStartCheckBox;
        private System.Windows.Forms.ComboBox player2ComboBox;
        private System.Windows.Forms.ComboBox player1ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}