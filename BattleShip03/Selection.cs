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
            shipChoices = new Ships[2];
            numAllowed = 3;
            SizeChoice();
        }

        private void btnBoard20_Click(object sender, EventArgs e)
        {
            shipChoices = new Ships[4];
            numAllowed = 5;
            SizeChoice();
        }

        private void btnBoard10_Click(object sender, EventArgs e)
        {
            shipChoices = new Ships[3];
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
            Ships aircraft = new Ships();

        }

        private void btnBattleship_Click(object sender, EventArgs e)
        {
            Ships battle = new Ships();

        }

        private void btnFrigate_Click(object sender, EventArgs e)
        {
            Ships frig = new Ships();

        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            Ships med = new Ships();

        }

        private void btnSubmarine_Click(object sender, EventArgs e)
        {
            Ships sub = new Ships();

        }

        private void btnDestroyer_Click(object sender, EventArgs e)
        {
            Ships dest = new Ships();
            BoatChoice(dest);
        }

        private void BoatChoice(Ships boat)
        {
            if (numSelected <= numAllowed)
            {
                shipChoices[numSelected] = boat;
            }
            if (numSelected == numAllowed)
            {
                btnBattleship.Enabled = false ; btnAircraft.Enabled = false ; btnMedical.Enabled = false ; btnFrigate.Enabled = false ; btnSubmarine.Enabled = false ; btnDestroyer.Enabled = false;
            }
        }
        
    }
}
