namespace CourseWork
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PvC = new System.Windows.Forms.Button();
            this.HighScore = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PvC
            // 
            this.PvC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PvC.Location = new System.Drawing.Point(318, 190);
            this.PvC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PvC.Name = "PvC";
            this.PvC.Size = new System.Drawing.Size(373, 91);
            this.PvC.TabIndex = 1;
            this.PvC.Text = "Play";
            this.PvC.UseVisualStyleBackColor = true;
            this.PvC.Click += new System.EventHandler(this.Play_Click);
            // 
            // HighScore
            // 
            this.HighScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HighScore.Location = new System.Drawing.Point(318, 314);
            this.HighScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(373, 91);
            this.HighScore.TabIndex = 2;
            this.HighScore.Text = "HighScore";
            this.HighScore.UseVisualStyleBackColor = true;
            this.HighScore.Click += new System.EventHandler(this.HighScore_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit.Location = new System.Drawing.Point(318, 436);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(373, 91);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 558);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.PvC);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PvC;
        private System.Windows.Forms.Button HighScore;
        private System.Windows.Forms.Button Exit;
    }
}