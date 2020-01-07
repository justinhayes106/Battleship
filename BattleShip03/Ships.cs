using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip03
{
    public class Ships
    {
        private int shots;
        private int health;
        private string shipname;
        private string pngMsg;
        private bool heal;
        private bool move;
        private bool planes;
        private bool fatal;
        
        public string ShipName
        { get { return shipname; } set { shipname = value; } }
        public int Health
        { get { return health; } set { health = value; } }
        public int Shots
        { get { return shots; } set { shots = value; } }
        public bool Heal
        { get { return heal; } set { heal = value; } }
        public bool Move
        { get { return move; } set { move = value; } }
        public bool Fatal
        { get { return fatal; } set { fatal = value; } }
        public bool Planes
        { get { return planes; } set { planes = value; } }
        public string Picture
        { get { return pngMsg; } set { pngMsg = value; } }

        public Ships(string name)
        {
            shipname = name;
            shots = 0;
            health = 0;
        }
        

        public void Attributes(Ships boat)
        {
            switch (boat.ShipName)
            {
                case "Submarine":
                    boat.shots = 1;
                    boat.health = 2;
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\sub_top.PNG";
                    break;
                case "Frigate":
                    boat.shots = 1;
                    boat.health = 2;
                    boat.move = true;
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\frigate_top.PNG";
                    break;
                case "Medical Frigate":
                    boat.shots = 1;
                    boat.health = 2;
                    boat.heal = true;
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\med_top.PNG";
                    break;
                case "Battleship":
                    boat.shots = 2;
                    boat.health = 3;
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\battleship_top.PNG";
                    break;
                case "Aircraft Carrier":
                    boat.shots = 1;
                    boat.health = 4;
                    boat.planes = true;
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\carrier_top.PNG";
                    break;
                case "Destroyer":
                    boat.shots = 1;
                    boat.health = 3;
                    boat.fatal = true;
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\destroyer_top.PNG";
                    break;
            }
            
        }

        public void Damage()
        {
            health--;
        }

        public void Healed()
        {
            health++;
        }

        //public void ShotFired()
        //{
        //    shotsLeft--;
        //}
    }
}
