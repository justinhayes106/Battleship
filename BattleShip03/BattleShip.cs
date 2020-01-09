using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip03
{
    public partial class BattleShip : Form
    {

        public Ships[] shipArray { get; set; }
        private Ships[] EnemyShipArray;
        private Button[] rButtonArray;
        private Button[] rButtonArrayA;

        public BattleShip(Ships[] list)
        {
            InitializeComponent();
            shipArray = list;
            Inventory();
            ButtonInitializer();
        }


        private void ButtonInitializer()
        {
            rButtonArray = new Button[] { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b10, b11, b12, b13, b14, b15, b16, b17, b18, b19, b20, b21, b22, b23, b24, b25, b26, b27, b28, b29, b30, b31, b32, b33, b34, b35, b36, b37, b38, b39, b40, b41, b42, b43, b44, b45, b46, b47, b48, b49, b50, b51, b52, b53, b54, b55, b56, b57, b58, b59, b60, b61, b62, b63, b64, b65, b66, b67, b68, b69, b70, b71, b72, b73, b74, b75, b76, b77, b78, b79, b80, b81, b82, b83, b84, b85, b86, b87, b88, b89, b90, b91, b92, b93, b94, b95, b96, b97, b98, b99, b100 };
            rButtonArrayA = new Button[] { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63, a64, a65, a66, a67, a68, a69, a70, a71, a72, a73, a74, a75, a76, a77, a78, a79, a80, a81, a82, a83, a84, a85, a86, a87, a88, a89, a90, a91, a92, a93, a94, a95, a96, a97, a98, a99, a100 };
 
            RanButtonChoice();
            Ships enemySub = new Ships("Submarine");
            Ships enemyFrig = new Ships("Frigate");
            Ships enemyBS = new Ships("Battleship");
            Ships enemyCarrier = new Ships("Aircraft Carrier");
            EnemyShipArray = new Ships[4] { enemySub, enemyFrig, enemyBS, enemyCarrier };
        }

        private void Inventory() //Displays bottom right panel
        {
            Ships first = shipArray[0];
            btnShip1.BackgroundImage = Image.FromFile(first.Picture);
            btnShip1.Text = first.ShipName;
            Ships sec = shipArray[1];
            btnShip2.BackgroundImage = Image.FromFile(sec.Picture);
            btnShip2.Text = sec.ShipName;
            Ships third = shipArray[2];
            btnShip3.BackgroundImage = Image.FromFile(third.Picture);
            btnShip3.Text = third.ShipName;
            Ships fourth = shipArray[3];
            btnShip4.BackgroundImage = Image.FromFile(fourth.Picture);
            btnShip4.Text = fourth.ShipName;
        }



        private void RanButtonChoice()
        {
            Random r = new Random();
            int i = 0;
            do
            { 
                int ranPlace = r.Next(0, 60); //Carrier | Always Vertical
                int place2 = ranPlace + 10;
                int place3 = ranPlace + 20;
                int place4 = ranPlace + 30;

                if (rButtonArray[ranPlace].Text == "" && rButtonArray[place2].Text == "" && rButtonArray[place3].Text == "" && rButtonArray[place4].Text == "")
                {
                    rButtonArray[ranPlace].Text = "C";
                    rButtonArray[place2].Text = "C";
                    rButtonArray[place3].Text = "C";
                    rButtonArray[place4].Text = "C";
                    i++; //Once the ship is properly set
                }

            } while (i != 1);

            int j = 0;
            do
            {
                int ranPlace = (r.Next(0, 8) + (r.Next(0, 10) * 10)); //BattleShip | Always Horizontal
                int place2 = ranPlace + 1;
                int place3 = ranPlace + 2;

                if (rButtonArray[ranPlace].Text == "" && rButtonArray[place2].Text == "" && rButtonArray[place3].Text == "")
                {
                    rButtonArray[ranPlace].Text = "B";
                    rButtonArray[place2].Text = "B";
                    rButtonArray[place3].Text = "B";
                    j++; //Once the ship is properly set
                }

            } while (j != 1);

            int k = 0;
            do
            {
                int ranPlace = r.Next(0, 60); //Frigate | Always Vertical
                int place2 = ranPlace + 10;


                if (rButtonArray[ranPlace].Text == "" && rButtonArray[place2].Text == "")
                {
                    rButtonArray[ranPlace].Text = "F";
                    rButtonArray[place2].Text = "F";

                    k++; //Once the ship is properly set
                }

            } while (k != 1);

            int l = 0;
            do
            {
                int ranPlace = (r.Next(0, 8) + (r.Next(0, 10) * 10)); //Sub | Always Horizontal
                int place2 = ranPlace + 1;

                if (rButtonArray[ranPlace].Text == "" && rButtonArray[place2].Text == "")
                {
                    rButtonArray[ranPlace].Text = "S";
                    rButtonArray[place2].Text = "S";
                    l++; //Once the ship is properly set
                }

            } while (l != 1);

        }

        Ships putDown;

        private void button184_Click(object sender, EventArgs e) //Links all info board bottons
        {


            Button selected = (Button)sender;

            Random r = new Random();
            if (putDown == null)
            {
                MessageBox.Show("Choose a new ship and select it's orientation.");
            }
            else
            {
                if (putDown.Health == 2)
                {
                    if (cbxOrientation.Checked == true) // Hori 2 Wide 
                    {
                        string strBase = selected.Name.Remove(0, 1); //PREVENT x9 +
                        int intBase = Convert.ToInt16(strBase);
                        int intSec = intBase + 1;

                        if (intBase % 10 != 0 && rButtonArrayA[intBase - 1].Text == "" && rButtonArrayA[intSec - 1].Text == "")
                        {
                            switch (putDown.ShipName)
                            {
                                case "Submarine":
                                    rButtonArrayA[intBase - 1].Text = "S";
                                    rButtonArrayA[intSec - 1].Text = "S";
                                    if (btnShip1.Text == "Submarine") 
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Submarine")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Submarine")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Submarine")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                                case "Medical Frigate":
                                    rButtonArrayA[intBase - 1].Text = "M";
                                    rButtonArrayA[intSec - 1].Text = "M";
                                    if (btnShip1.Text == "Medical Frigate")
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Medical Frigate")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Medical Frigate")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Medical Frigate")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                                case "Frigate":
                                    rButtonArrayA[intBase - 1].Text = "F";
                                    rButtonArrayA[intSec - 1].Text = "F";
                                    if (btnShip1.Text == "Frigate")
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Frigate")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Frigate")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Frigate")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                            }
                            putDown = null;
                        }
                    }
                    else //Vertical 2 Wide
                    {
                        string strBase = selected.Name.Remove(0, 1); 
                        int intBase = Convert.ToInt16(strBase);
                        int intSec = intBase + 10;

                        if (intBase <= 90 && rButtonArrayA[intBase - 1].Text == "" && rButtonArrayA[intSec - 1].Text == "")
                        {
                            switch (putDown.ShipName)
                            {
                                case "Submarine":
                                    rButtonArrayA[intBase - 1].Text = "S";
                                    rButtonArrayA[intSec - 1].Text = "S";
                                    if (btnShip1.Text == "Submarine")
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Submarine")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Submarine")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Submarine")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                                case "Medical Frigate":
                                    rButtonArrayA[intBase - 1].Text = "M";
                                    rButtonArrayA[intSec - 1].Text = "M";
                                    if (btnShip1.Text == "Medical Frigate")
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Medical Frigate")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Medical Frigate")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Medical Frigate")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                                case "Frigate":
                                    rButtonArrayA[intBase - 1].Text = "F";
                                    rButtonArrayA[intSec - 1].Text = "F";
                                    if (btnShip1.Text == "Frigate")
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Frigate")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Frigate")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Frigate")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                            }
                            putDown = null;
                        }

                    }
                }
                else if (putDown.Health == 3)
                {
                    if (cbxOrientation.Checked == true) //3 Wide Horizontal
                    {
                        string strBase = selected.Name.Remove(0, 1); //PREVENT x9 +
                        int intBase = Convert.ToInt16(strBase);
                        int intSec = intBase + 1;
                        int intThird = intSec + 1;

                        if (intBase % 10 != 0 && (intBase + 1) % 10 != 0 && rButtonArrayA[intBase - 1].Text == "" && rButtonArrayA[intSec - 1].Text == "" && rButtonArrayA[intThird - 1].Text == "")
                        {
                            switch (putDown.ShipName)
                            {
                                case "Battleship":
                                    rButtonArrayA[intBase - 1].Text = "B";
                                    rButtonArrayA[intSec - 1].Text = "B";
                                    rButtonArrayA[intThird - 1].Text = "B";
                                    if (btnShip1.Text == "Battleship")
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Battleship")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Battleship")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Battleship")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                                case "Destroyer":
                                    rButtonArrayA[intBase - 1].Text = "D";
                                    rButtonArrayA[intSec - 1].Text = "D";
                                    rButtonArrayA[intThird - 1].Text = "D";
                                    if (btnShip1.Text == "Destroyer")
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Destroyer")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Destroyer")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Destroyer")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                            }
                            putDown = null;
                        }
                    }
                    else
                    {
                        string strBase = selected.Name.Remove(0, 1); // 3 Wide Verti
                        int intBase = Convert.ToInt16(strBase);
                        int intSec = intBase + 10;
                        int intThird = intSec + 10;

                        if (intBase <= 80 && rButtonArrayA[intBase - 1].Text == "" && rButtonArrayA[intSec - 1].Text == "" && rButtonArrayA[intThird - 1].Text == "")
                        {
                            switch (putDown.ShipName)
                            {
                                case "Battleship":
                                    rButtonArrayA[intBase - 1].Text = "B";
                                    rButtonArrayA[intSec - 1].Text = "B";
                                    rButtonArrayA[intThird - 1].Text = "B";
                                    if (btnShip1.Text == "Battleship")
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Battleship")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Battleship")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Battleship")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                                case "Destroyer":
                                    rButtonArrayA[intBase - 1].Text = "D";
                                    rButtonArrayA[intSec - 1].Text = "D";
                                    rButtonArrayA[intThird - 1].Text = "D";
                                    if (btnShip1.Text == "Destroyer")
                                    {
                                        btnShip1.Enabled = false;
                                    }
                                    else if (btnShip2.Text == "Destroyer")
                                    {
                                        btnShip2.Enabled = false;
                                    }
                                    else if (btnShip3.Text == "Destroyer")
                                    {
                                        btnShip3.Enabled = false;
                                    }
                                    else if (btnShip4.Text == "Destroyer")
                                    {
                                        btnShip4.Enabled = false;
                                    }
                                    break;
                            }
                            putDown = null;
                        }
                    }
                }
                else if (putDown.Health == 4)
                {
                    if (cbxOrientation.Checked == true) //Hori Airc
                    {
                        string strBase = selected.Name.Remove(0, 1); //PREVENT x9 +
                        int intBase = Convert.ToInt16(strBase);
                        int intSec = intBase + 1;
                        int intThird = intSec + 1;
                        int intFourth = intThird + 1;


                        if (intBase % 10 != 0 && (intBase + 1) % 10 != 0 && (intBase + 2) % 10 != 0 &&  rButtonArrayA[intBase - 1].Text == "" && rButtonArrayA[intSec - 1].Text == "" && rButtonArrayA[intThird - 1].Text == "" && rButtonArrayA[intFourth - 1].Text == "")
                        {
                            rButtonArrayA[intBase - 1].Text = "A";
                            rButtonArrayA[intSec - 1].Text = "A";
                            rButtonArrayA[intThird - 1].Text = "A";
                            rButtonArrayA[intFourth - 1].Text = "A";
                            if (btnShip1.Text == "Aircraft Carrier")
                            {
                                btnShip1.Enabled = false;
                            }
                            else if (btnShip2.Text == "Aircraft Carrier")
                            {
                                btnShip2.Enabled = false;
                            }
                            else if (btnShip3.Text == "Aircraft Carrier")
                            {
                                btnShip3.Enabled = false;
                            }
                            else if (btnShip4.Text == "Aircraft Carrier")
                            {
                                btnShip4.Enabled = false;
                            }
                            putDown = null;
                        }

                    }
                    else
                    {
                        string strBase = selected.Name.Remove(0, 1);
                        int intBase = Convert.ToInt16(strBase);
                        int intSec = intBase + 10;
                        int intThird = intSec + 10;
                        int intFourth = intThird + 10;

                        if (intBase <= 70 && rButtonArrayA[intBase - 1].Text == "" && rButtonArrayA[intSec - 1].Text == "" && rButtonArrayA[intThird - 1].Text == "" && rButtonArrayA[intFourth - 1].Text == "") 
                        {
                            rButtonArrayA[intBase - 1].Text = "A";
                            rButtonArrayA[intSec - 1].Text = "A";
                            rButtonArrayA[intThird - 1].Text = "A";
                            rButtonArrayA[intFourth - 1].Text = "A";
                            if (btnShip1.Text == "Aircraft Carrier")
                            {
                                btnShip1.Enabled = false;
                            }
                            else if (btnShip2.Text == "Aircraft Carrier")
                            {
                                btnShip2.Enabled = false;
                            }
                            else if (btnShip3.Text == "Aircraft Carrier")
                            {
                                btnShip3.Enabled = false;
                            }
                            else if (btnShip4.Text == "Aircraft Carrier")
                            {
                                btnShip4.Enabled = false;
                            }
                            putDown = null;
                        }

                    }
                }

            }

            if (btnShip1.Enabled == false && btnShip2.Enabled == false && btnShip3.Enabled == false && btnShip4.Enabled == false)
            {
                setup = true;
                MessageBox.Show("Setup Complete: Destroy the enemy!");
            }
        }

        private void button84_Click(object sender, EventArgs e) //Links all fire board bottons
        {
            //DONOT DELETE WILL BREAK
        }

        private bool setup = false;
        private int shotsUsed = 0;

        private void b100_Click(object sender, EventArgs e)
        {
            if (setup)
            {
                if (shotsUsed <= 3)
                {
                    Button selection = (Button)sender;
                    Selected(selection);
                    shotsUsed++;
                }
                if (shotsUsed == 4)
                {
                    shotsUsed = 0;
                    int shotsFired = 0;
                    int boatsLeft = 0;
                    foreach (Ships ship in EnemyShipArray)
                    {
                        boatsLeft++;
                    } 
                    foreach (Ships ship in EnemyShipArray)
                    {
                        Random r = new Random();
                        do
                        {
                            int ranShot = r.Next(1, 101);
                            if (rButtonArrayA[ranShot - 1].Text != "H")
                            {
                                rButtonArrayA[ranShot - 1].Text = "H";
                                rButtonArrayA[ranShot - 1].BackgroundImage = Image.FromFile("E:\\BattleShip03\\BattleShip03\\Resources\\background_x.PNG");
                                shotsFired++;
                            }
                        } while (shotsFired != boatsLeft);
                    }
                }
            }
            else
            {
                MessageBox.Show("Finish organizning your fleet!");
            }

            int enemyCounter = 0;
            foreach (Button tile in rButtonArrayA) //Player Ships
            {
                if (tile.Text != "A" && tile.Text != "B" && tile.Text != "D" && tile.Text != "F" && tile.Text != "M" && tile.Text != "S")
                {
                    enemyCounter++;
                }
            }
            int playerHits = 0;
            foreach (Button tile in rButtonArray) //Enemy Ships
            {
                if (tile.Text == "H")
                {
                    playerHits++;
                }
            }
            if (playerHits == 11)
            {
                MessageBox.Show("Game Over: You WIN!");
            }
            if (enemyCounter == 100)
            {
                MessageBox.Show("Game Over: You Loose!");
            }
        }

        private void Selected(Button selection)
        {
            string fileID = "E:\\BattleShip03\\BattleShip03\\Resources\\background_x.PNG";

            if (selection.BackgroundImage == null)
            {
                if (selection.Text == "")
                {
                    selection.BackgroundImage = Image.FromFile(fileID);
                }
                else
                {
                    selection.BackgroundImage = Image.FromFile("E:\\BattleShip03\\BattleShip03\\Resources\\background_x2.PNG");
                    selection.Text = "H";
                }
            }
            else
            {
                MessageBox.Show("This space is already hit!");
            }
           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }



        private void btnShip3_Click_1(object sender, EventArgs e)
        {
            Button chosen = (Button)sender;

            if (chosen.Text == shipArray[0].ShipName)
            {
                putDown = shipArray[0];

            }
            else if (chosen.Text == shipArray[1].ShipName)
            {
                putDown = shipArray[1];

            }
            else if (chosen.Text == shipArray[2].ShipName)
            {
                putDown = shipArray[2];

            }
            else if (chosen.Text == shipArray[3].ShipName)
            {
                putDown = shipArray[3];

            }
        }
    }
}
