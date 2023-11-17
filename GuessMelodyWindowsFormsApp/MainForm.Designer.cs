namespace GuessMelodyWindowsFormsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.playButton = new System.Windows.Forms.Button();
            this.parametrsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playButton.Location = new System.Drawing.Point(147, 39);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(168, 64);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Spielen";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // parametrsButton
            // 
            this.parametrsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parametrsButton.Location = new System.Drawing.Point(147, 141);
            this.parametrsButton.Name = "parametrsButton";
            this.parametrsButton.Size = new System.Drawing.Size(168, 64);
            this.parametrsButton.TabIndex = 1;
            this.parametrsButton.Text = "Regelung";
            this.parametrsButton.UseVisualStyleBackColor = true;
            this.parametrsButton.Click += new System.EventHandler(this.parametrsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(147, 236);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 64);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Verlassen";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelodyWindowsFormsApp.Properties.Resources.melodiBild;
            this.ClientSize = new System.Drawing.Size(489, 363);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.parametrsButton);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Erraten Sie die Melodie!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button parametrsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

