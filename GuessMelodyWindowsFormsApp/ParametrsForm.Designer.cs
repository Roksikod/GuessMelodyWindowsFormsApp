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
            this.selectFolderButton.Location = new System.Drawing.Point(54, 217);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(144, 43);
            this.selectFolderButton.TabIndex = 1;
            this.selectFolderButton.Text = "Aussuchen";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearListButton.Location = new System.Drawing.Point(653, 217);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(113, 43);
            this.clearListButton.TabIndex = 2;
            this.clearListButton.Text = "Leeren";
            this.clearListButton.UseVisualStyleBackColor = true;
            // 
            // allDirectoryCheckBox
            // 
            this.allDirectoryCheckBox.AutoSize = true;
            this.allDirectoryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allDirectoryCheckBox.Location = new System.Drawing.Point(262, 236);
            this.allDirectoryCheckBox.Name = "allDirectoryCheckBox";
            this.allDirectoryCheckBox.Size = new System.Drawing.Size(131, 24);
            this.allDirectoryCheckBox.TabIndex = 3;
            this.allDirectoryCheckBox.Text = "Unterordner";
            this.allDirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(85, 324);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(113, 52);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(622, 314);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 52);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Stornierungen";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ParametrsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 409);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.allDirectoryCheckBox);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.musicListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParametrsForm";
            this.Text = "Regelung";
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
    }
}