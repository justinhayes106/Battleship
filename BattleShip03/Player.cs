using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BattleShip03
{
    abstract class Player
    {
        public int wins;
        public int losses;

        public void UpdateWins()
        {
            wins++;
        }

        public void UpdateLosses()
        {
            losses++;
        }

        public void Output()
        {
            
        }

        abstract public void WinConditions(Button[] btnArray);



    }
}
