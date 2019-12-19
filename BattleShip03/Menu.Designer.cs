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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pbxBattleShip = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnResumeGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattleShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBattleShip
            // 
            this.pbxBattleShip.Image = ((System.Drawing.Image)(resources.GetObject("pbxBattleShip.Image")));
            this.pbxBattleShip.Location = new System.Drawing.Point(130, 89);
            this.pbxBattleShip.Name = "pbxBattleShip";
            this.pbxBattleShip.Size = new System.Drawing.Size(184, 182);
            this.pbxBattleShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBattleShip.TabIndex = 11;
            this.pbxBattleShip.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(22, 230);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 41);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(22, 183);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 41);
            this.btnStats.TabIndex = 9;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnResumeGame
            // 
            this.btnResumeGame.Location = new System.Drawing.Point(22, 136);
            this.btnResumeGame.Name = "btnResumeGame";
            this.btnResumeGame.Size = new System.Drawing.Size(75, 41);
            this.btnResumeGame.TabIndex = 8;
            this.btnResumeGame.Text = "Resume Game";
            this.btnResumeGame.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(22, 89);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 41);
            this.btnNewGame.TabIndex = 7;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(74, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(157, 37);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Battleship";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 281);
            this.Controls.Add(this.pbxBattleShip);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnResumeGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.Label1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattleShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pbxBattleShip;
        internal System.Windows.Forms.Button btnHelp;
        internal System.Windows.Forms.Button btnStats;
        internal System.Windows.Forms.Button btnResumeGame;
        internal System.Windows.Forms.Button btnNewGame;
        internal System.Windows.Forms.Label Label1;
    }
}

