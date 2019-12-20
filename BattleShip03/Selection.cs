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

        private int sizeChoice;
        private int numAllowed = 0;
        private int numSelected = 0;
        private Ships[] shipChoices;

        private void btnBoard7_Click(object sender, EventArgs e)
        {
            shipChoices = new Ships[3];
            numAllowed = 3;
            SizeChoice();
        }

        private void btnBoard20_Click(object sender, EventArgs e)
        {
            shipChoices = new Ships[5];
            numAllowed = 5;
            SizeChoice();
        }

        private void btnBoard10_Click(object sender, EventArgs e)
        {
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
            Ships aircraft = new Ships("a", "b", "c");
            BoatChoice(aircraft);
            btnAircraft.Enabled = false;

        }

        private void btnBattleship_Click(object sender, EventArgs e)
        {
            Ships battle = new Ships("a", "b", "c", "d");
            BoatChoice(battle);
            btnBattleship.Enabled = false;
        }

        private void btnFrigate_Click(object sender, EventArgs e)
        {
            Ships frig = new Ships("a");
            BoatChoice(frig);
            btnFrigate.Enabled = false;
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            Ships med = new Ships();
            BoatChoice(med);
            btnMedical.Enabled = false;
        }

        private void btnSubmarine_Click(object sender, EventArgs e)
        {
            Ships sub = new Ships();
            BoatChoice(sub);
            btnSubmarine.Enabled = false;
        }

        private void btnDestroyer_Click(object sender, EventArgs e)
        {
            Ships dest = new Ships("a", "b");
            BoatChoice(dest);
            btnDestroyer.Enabled = false;
        }

        private void BoatChoice(Ships boat)
        {
            if (numSelected <= numAllowed)
            {
                shipChoices[numSelected] = boat;
                statlable.Text += boat.ShipName + "\n";
                numSelected++;
            }
            if (numSelected == numAllowed)
            {
                MessageBox.Show("Max Ships Chosen");
                btnDestroyer.Enabled = false; btnSubmarine.Enabled = false; btnMedical.Enabled = false; btnFrigate.Enabled = false; btnBattleship.Enabled = false; btnAircraft.Enabled = false;

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
        }
    }
}
