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
            RanButtonChoice();
            Ships enemySub = new Ships("Submarine");
            Ships enemyFrig = new Ships("Frigate");
            Ships enemyBS = new Ships("Battleship");
            Ships enemyCarrier = new Ships("Aircraft Carrier");
            EnemyShipArray = new Ships[4] { enemySub, enemyFrig, enemyBS, enemyCarrier };
        }

        private bool setup = false;
        private int slotsUsed;
        int intSlots;

        private int shotsTotal = 0;
        private int shotsUsed = 0;


        private void Inventory() //Displays bottom right panel
        {
            Ships first = shipArray[0];
            pbxShip1.BackgroundImage = Image.FromFile(first.Picture);
            intSlots += first.Health;
            Ships sec = shipArray[1];
            pbxShip2.BackgroundImage = Image.FromFile(sec.Picture);
            intSlots += sec.Health;
            Ships third = shipArray[2];
            pbxShip3.BackgroundImage = Image.FromFile(third.Picture);
            intSlots += third.Health;
            Ships fourth = shipArray[3];
            pbxShip4.BackgroundImage = Image.FromFile(fourth.Picture);
            intSlots += fourth.Health;
        }

        int shipSize = 0;

        private void pbxShip1_Click(object sender, EventArgs e)
        {
            PictureBox chosen = (PictureBox)sender;

            if (chosen.BackgroundImage == Image.FromFile(shipArray[0].Picture))
            {
                shipSize = shipArray[0].Health;

            }
            else if (chosen.BackgroundImage == Image.FromFile(shipArray[1].Picture))
            {
                shipSize = shipArray[1].Health;

            }
            else if (chosen.BackgroundImage == Image.FromFile(shipArray[2].Picture))
            {
                shipSize = shipArray[2].Health;

            }
            else if (chosen.BackgroundImage == Image.FromFile(shipArray[3].Picture))
            {
                shipSize = shipArray[3].Health;

            }
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

        private void button184_Click(object sender, EventArgs e) //Links all info board bottons
        {
            if (slotsUsed != intSlots)
            {   
                Button selection = (Button)sender;
                if (selection.BackgroundImage != Image.FromFile("E:\\BattleShip03\\BattleShip03\\Resources\\background_x2.PNG"))
                {
                    selection.BackgroundImage = Image.FromFile("E:\\BattleShip03\\BattleShip03\\Resources\\background_x2.PNG");
                }
                slotsUsed++;
            }
            else
            {
                setup = true;
            }
        }

        private void button84_Click(object sender, EventArgs e) //Links all fire board bottons
        {

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

        private void b100_Click(object sender, EventArgs e)
        {
                    foreach (Ships ship in shipArray)
                    {
                        shotsTotal += ship.Shots;
                    }
                    if (setup)
                    {
                        if (shotsTotal >= shotsUsed)
                        {
                            Button selection = (Button)sender;
                            Selected(selection);
                        }
                        else
                        {
                            //ENEMY SHOOTS BACK
                        }
                    }
        }


    }
}
