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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private int numAllowed = 0;
        private int numSelected = 0;
        private Ships[] shipChoices;

        private void btnBoard7_Click(object sender, EventArgs e)
        {
            Board lake = new Board(7);
            shipChoices = new Ships[3];
            numAllowed = 3;
            SizeChoice();
        }

        private void btnBoard20_Click(object sender, EventArgs e)
        {
            Board ocean = new Board(20);
            shipChoices = new Ships[5];
            numAllowed = 5;
            SizeChoice();
        }

        private void btnBoard10_Click(object sender, EventArgs e)
        {
            Board sea = new Board(10);
            shipChoices = new Ships[4];
            numAllowed = 4;
            SizeChoice();
        }

        private void SizeChoice()
        {            
            btnBattleship.Enabled = true; btnAircraft.Enabled = true; btnMedical.Enabled = true; btnFrigate.Enabled = true; btnSubmarine.Enabled = true; btnDestroyer.Enabled = true;
            btnBoard10.Enabled = false; btnBoard7.Enabled = false; btnBoard20.Enabled = false;
        }

        private void btnAircraft_Click(object sender, EventArgs e)
        {
            Ships aircraft = new Ships("Aircraft Carrier");
            aircraft.Attributes(aircraft);
            BoatChoice(aircraft);
            btnAircraft.Enabled = false;

        }

        private void btnBattleship_Click(object sender, EventArgs e)
        {
            Ships battle = new Ships("Battleship");
            battle.Attributes(battle);
            BoatChoice(battle);
            btnBattleship.Enabled = false;
        }

        private void btnFrigate_Click(object sender, EventArgs e)
        {
            Ships frig = new Ships("Frigate");
            frig.Attributes(frig);
            BoatChoice(frig);
            btnFrigate.Enabled = false;
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            Ships med = new Ships("Medical Frigate");
            med.Attributes(med);
            BoatChoice(med);
            btnMedical.Enabled = false;
        }

        private void btnSubmarine_Click(object sender, EventArgs e)
        {
            Ships sub = new Ships("Submarine");
            sub.Attributes(sub);
            BoatChoice(sub);
            btnSubmarine.Enabled = false;
        }

        private void btnDestroyer_Click(object sender, EventArgs e)
        {
            Ships dest = new Ships("Destroyer");
            dest.Attributes(dest);
            BoatChoice(dest);
            btnDestroyer.Enabled = false;
            btnDestroyer.FlatStyle = FlatStyle.Flat; 
        }

        private void StatUpate(Ships boat)
        {
            statlable.Text = "Shots: " + boat.Shots + "\n" + "Health: " + boat.Health;
            string msg = "";
            if (boat.Fatal == true)
                msg = "This ship's surface to surface missile can eliminate in a single hit.";
            if (boat.Heal == true)
                msg = "This ship carries medical supplies for a one time, 3x3 health boost.";
            if (boat.Planes == true)
                msg = "This ship can perform recon with the use of onboard planes.";
            if (boat.Move == true)
                msg = "This agile ship can relocate once, onto any tiles not already fired upon.";
            statlable.Text += "\n" + msg;
        }

        private void BoatChoice(Ships boat)
        {
            if (numSelected <= numAllowed)
            {
                shipChoices[numSelected] = boat;
                StatUpate(boat);
                pbxTopDown.Image = Image.FromFile(boat.Picture);
                pbxTopDown.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxTopDown.BorderStyle = BorderStyle.FixedSingle;
                lblShipName.Text = boat.ShipName;
                numSelected++;
            }
            if (numSelected == numAllowed)
            {
                MessageBox.Show("Max Ships Chosen");
                btnDestroyer.Enabled = false; btnSubmarine.Enabled = false; btnMedical.Enabled = false; btnFrigate.Enabled = false; btnBattleship.Enabled = false; btnAircraft.Enabled = false;
                btnCont.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnDestroyer.Enabled = false; btnSubmarine.Enabled = false; btnMedical.Enabled = false; btnFrigate.Enabled = false; btnBattleship.Enabled = false; btnAircraft.Enabled = false;
            btnBoard10.Enabled = true ; btnBoard7.Enabled = true ; btnBoard20.Enabled = true ;
            statlable.Text = "";
            Array.Clear(shipChoices, 0, shipChoices.Length);
            numSelected = 0;
            numAllowed = 0;
            btnCont.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Close();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            BattleShip board = new BattleShip(shipChoices);
            board.Show();
            this.Close();
        }


    }
}
