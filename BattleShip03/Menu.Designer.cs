namespace BattleShip03
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pbxBattleShip = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattleShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BattleShip03.Properties.Resources.text_2quit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(246, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BattleShip03.Properties.Resources.title_text;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = global::BattleShip03.Properties.Resources.text_help;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHelp.Location = new System.Drawing.Point(165, 236);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 41);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "\r\n";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackgroundImage = global::BattleShip03.Properties.Resources.text_stats;
            this.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStats.Location = new System.Drawing.Point(84, 236);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 41);
            this.btnStats.TabIndex = 9;
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackgroundImage = global::BattleShip03.Properties.Resources.text_play;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.Location = new System.Drawing.Point(3, 236);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 41);
            this.btnNewGame.TabIndex = 7;
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pbxBattleShip
            // 
            this.pbxBattleShip.Image = global::BattleShip03.Properties.Resources.battleship_side;
            this.pbxBattleShip.Location = new System.Drawing.Point(-1, 70);
            this.pbxBattleShip.Name = "pbxBattleShip";
            this.pbxBattleShip.Size = new System.Drawing.Size(326, 178);
            this.pbxBattleShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBattleShip.TabIndex = 11;
            this.pbxBattleShip.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BattleShip03.Properties.Resources.background_blue;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 214);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pbxBattleShip);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattleShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pbxBattleShip;
        internal System.Windows.Forms.Button btnHelp;
        internal System.Windows.Forms.Button btnStats;
        internal System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Button button1;
    }
}

