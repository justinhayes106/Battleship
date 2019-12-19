using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip03
{
    sealed class Game
    {
        private bool gameOver;
        private bool shipLayout;


        public Game(Board gameBoard, Player plyHuman, Player plyComp)
        {
            




        }

        public void Play()
        {
            do //Put ships on board
            {


            } while (!shipLayout);

            do //Play the game
            {

            } while (!gameOver);
        }

        private void Layout(ref Board board, Human player, Ships ship)
        {
            foreach (Ships boat in player.boats)
            {
                
            }


        }

        private void MyMove()
        {
            //shots left > 0))
        }

        private void CompMove()
        {
            //choose spot, fire if empty
        }
    }
}
