namespace BattleShip03
{
    partial class Selection
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
            this.statlable = new System.Windows.Forms.Label();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDestroyer = new System.Windows.Forms.Button();
            this.btnBattleship = new System.Windows.Forms.Button();
            this.btnFrigate = new System.Windows.Forms.Button();
            this.btnMedical = new System.Windows.Forms.Button();
            this.btnSubmarine = new System.Windows.Forms.Button();
            this.btnBoard20 = new System.Windows.Forms.Button();
            this.btnBoard10 = new System.Windows.Forms.Button();
            this.btnBoard7 = new System.Windows.Forms.Button();
            this.btnAircraft = new System.Windows.Forms.Button();
            this.pbxTopDown = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShipName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statlable
            // 
            this.statlable.BackColor = System.Drawing.Color.Silver;
            this.statlable.Font = new System.Drawing.Font("Courier New", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statlable.Location = new System.Drawing.Point(3, 113);
            this.statlable.Name = "statlable";
            this.statlable.Size = new System.Drawing.Size(179, 104);
            this.statlable.TabIndex = 31;
            this.statlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCont
            // 
            this.btnCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCont.Location = new System.Drawing.Point(450, 361);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(84, 24);
            this.btnCont.TabIndex = 28;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(339, 361);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 24);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(226, 361);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 24);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDestroyer
            // 
            this.btnDestroyer.BackgroundImage = global::BattleShip03.Properties.Resources.destroyer_side;
            this.btnDestroyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDestroyer.Enabled = false;
            this.btnDestroyer.Location = new System.Drawing.Point(386, 235);
            this.btnDestroyer.Name = "btnDestroyer";
            this.btnDestroyer.Size = new System.Drawing.Size(175, 107);
            this.btnDestroyer.TabIndex = 25;
            this.btnDestroyer.UseVisualStyleBackColor = true;
            this.btnDestroyer.Click += new System.EventHandler(this.btnDestroyer_Click);
            // 
            // btnBattleship
            // 
            this.btnBattleship.BackgroundImage = global::BattleShip03.Properties.Resources.battleship_side;
            this.btnBattleship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBattleship.Enabled = false;
            this.btnBattleship.Location = new System.Drawing.Point(205, 235);
            this.btnBattleship.Name = "btnBattleship";
            this.btnBattleship.Size = new System.Drawing.Size(175, 107);
            this.btnBattleship.TabIndex = 24;
            this.btnBattleship.UseVisualStyleBackColor = true;
            this.btnBattleship.Click += new System.EventHandler(this.btnBattleship_Click);
            // 
            // btnFrigate
            // 
            this.btnFrigate.BackgroundImage = global::BattleShip03.Properties.Resources.frigate_side;
            this.btnFrigate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrigate.Enabled = false;
            this.btnFrigate.Location = new System.Drawing.Point(24, 235);
            this.btnFrigate.Name = "btnFrigate";
            this.btnFrigate.Size = new System.Drawing.Size(175, 107);
            this.btnFrigate.TabIndex = 23;
            this.btnFrigate.UseVisualStyleBackColor = true;
            this.btnFrigate.Click += new System.EventHandler(this.btnFrigate_Click);
            // 
            // btnMedical
            // 
            this.btnMedical.BackgroundImage = global::BattleShip03.Properties.Resources.med_side;
            this.btnMedical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedical.Enabled = false;
            this.btnMedical.Location = new System.Drawing.Point(386, 122);
            this.btnMedical.Name = "btnMedical";
            this.btnMedical.Size = new System.Drawing.Size(175, 107);
            this.btnMedical.TabIndex = 22;
            this.btnMedical.UseVisualStyleBackColor = true;
            this.btnMedical.Click += new System.EventHandler(this.btnMedical_Click);
            // 
            // btnSubmarine
            // 
            this.btnSubmarine.BackgroundImage = global::BattleShip03.Properties.Resources.sub_side;
            this.btnSubmarine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmarine.Enabled = false;
            this.btnSubmarine.Location = new System.Drawing.Point(205, 122);
            this.btnSubmarine.Name = "btnSubmarine";
            this.btnSubmarine.Size = new System.Drawing.Size(175, 107);
            this.btnSubmarine.TabIndex = 21;
            this.btnSubmarine.UseVisualStyleBackColor = true;
            this.btnSubmarine.Click += new System.EventHandler(this.btnSubmarine_Click);
            // 
            // btnBoard20
            // 
            this.btnBoard20.BackgroundImage = global::BattleShip03.Properties.Resources._20_text;
            this.btnBoard20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoard20.Location = new System.Drawing.Point(525, 17);
            this.btnBoard20.Name = "btnBoard20";
            this.btnBoard20.Size = new System.Drawing.Size(166, 82);
            this.btnBoard20.TabIndex = 19;
            this.btnBoard20.UseVisualStyleBackColor = true;
            this.btnBoard20.Visible = false;
            this.btnBoard20.Click += new System.EventHandler(this.btnBoard20_Click);
            // 
            // btnBoard10
            // 
            this.btnBoard10.BackgroundImage = global::BattleShip03.Properties.Resources._10_text;
            this.btnBoard10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoard10.Location = new System.Drawing.Point(304, 18);
            this.btnBoard10.Name = "btnBoard10";
            this.btnBoard10.Size = new System.Drawing.Size(167, 82);
            this.btnBoard10.TabIndex = 18;
            this.btnBoard10.UseVisualStyleBackColor = true;
            this.btnBoard10.Click += new System.EventHandler(this.btnBoard10_Click);
            // 
            // btnBoard7
            // 
            this.btnBoard7.BackgroundImage = global::BattleShip03.Properties.Resources._7_text;
            this.btnBoard7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoard7.Location = new System.Drawing.Point(86, 18);
            this.btnBoard7.Name = "btnBoard7";
            this.btnBoard7.Size = new System.Drawing.Size(167, 82);
            this.btnBoard7.TabIndex = 17;
            this.btnBoard7.UseVisualStyleBackColor = true;
            this.btnBoard7.Visible = false;
            this.btnBoard7.Click += new System.EventHandler(this.btnBoard7_Click);
            // 
            // btnAircraft
            // 
            this.btnAircraft.BackgroundImage = global::BattleShip03.Properties.Resources.carrier_side;
            this.btnAircraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAircraft.Enabled = false;
            this.btnAircraft.Location = new System.Drawing.Point(24, 122);
            this.btnAircraft.Name = "btnAircraft";
            this.btnAircraft.Size = new System.Drawing.Size(175, 107);
            this.btnAircraft.TabIndex = 20;
            this.btnAircraft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAircraft.UseVisualStyleBackColor = true;
            this.btnAircraft.Click += new System.EventHandler(this.btnAircraft_Click);
            // 
            // pbxTopDown
            // 
            this.pbxTopDown.BackColor = System.Drawing.Color.Silver;
            this.pbxTopDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxTopDown.Location = new System.Drawing.Point(3, 48);
            this.pbxTopDown.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pbxTopDown.Name = "pbxTopDown";
            this.pbxTopDown.Size = new System.Drawing.Size(179, 59);
            this.pbxTopDown.TabIndex = 32;
            this.pbxTopDown.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblShipName);
            this.panel1.Controls.Add(this.pbxTopDown);
            this.panel1.Controls.Add(this.statlable);
            this.panel1.Location = new System.Drawing.Point(569, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 220);
            this.panel1.TabIndex = 33;
            // 
            // lblShipName
            // 
            this.lblShipName.BackColor = System.Drawing.Color.Silver;
            this.lblShipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipName.Location = new System.Drawing.Point(4, 6);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(179, 36);
            this.lblShipName.TabIndex = 33;
            this.lblShipName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(770, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDestroyer);
            this.Controls.Add(this.btnBattleship);
            this.Controls.Add(this.btnFrigate);
            this.Controls.Add(this.btnMedical);
            this.Controls.Add(this.btnSubmarine);
            this.Controls.Add(this.btnAircraft);
            this.Controls.Add(this.btnBoard20);
            this.Controls.Add(this.btnBoard10);
            this.Controls.Add(this.btnBoard7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label statlable;
        internal System.Windows.Forms.Button btnCont;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnDestroyer;
        internal System.Windows.Forms.Button btnBattleship;
        internal System.Windows.Forms.Button btnFrigate;
        internal System.Windows.Forms.Button btnMedical;
        internal System.Windows.Forms.Button btnSubmarine;
        internal System.Windows.Forms.Button btnAircraft;
        internal System.Windows.Forms.Button btnBoard20;
        internal System.Windows.Forms.Button btnBoard10;
        internal System.Windows.Forms.Button btnBoard7;
        private System.Windows.Forms.PictureBox pbxTopDown;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lblShipName;
        
    }
}