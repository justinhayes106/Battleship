using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip03
{
    sealed class Computer : Player
    {

        public Computer()
        {
            
        }

        public override void WinConditions(Button[] btnArray)
        {
            int enemyCounter = 0;
            foreach (Button tile in btnArray) //Player Ships
            {
                if (tile.Text != "A" && tile.Text != "B" && tile.Text != "D" && tile.Text != "F" && tile.Text != "M" && tile.Text != "S")
                {
                    enemyCounter++;
                }
            }

            if (enemyCounter == 100)
            {
                MessageBox.Show("Game Over: You Loose!");
            }

            UpdateWins();
        }

    }
}
