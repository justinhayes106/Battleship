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
        private string strAbility;

        
        public string ShipName
        { get { return shipname; } set { shipname = value; } }
        public int Health
        { get { return health; } set { health = value; } }
        public int Shots
        { get { return shots; } set { shots = value; } }
        public string Picture
        { get { return pngMsg; } set { pngMsg = value; } }
        public string Ability
        { get { return strAbility; } set { strAbility = value; } }

        public Ships()
        {
            ShipName = "Default";
            Shots = 1;
            Health = 3;
            Ability = null;
        }

        public Ships(string name)
        {
            shipname = name;
        }   

        public void Attributes(Ships boat)
        {
            switch (boat.ShipName)
            {
                case "Submarine":
                    boat.shots = 1;
                    boat.health = 2;
                    boat.Ability = "Stealth";
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\sub_top.PNG";
                    break;
                case "Frigate":
                    boat.shots = 1;
                    boat.health = 2;
                    boat.Ability = "None";
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\frigate_top.PNG";
                    break;
                case "Medical Frigate":
                    boat.shots = 1;
                    boat.health = 2;
                    boat.Ability = "Heal";
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\med_top.PNG";
                    break;
                case "Battleship":
                    boat.shots = 2;
                    boat.health = 3;
                    boat.Ability = "Barrage";
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\battleship_top.PNG";
                    break;
                case "Aircraft Carrier":
                    boat.shots = 1;
                    boat.health = 4;
                    boat.Ability = "Recon";
                    pngMsg = "E:\\BattleShip03\\BattleShip03\\Resources\\pictures\\carrier_top.PNG";
                    break;
                case "Destroyer":
                    boat.shots = 1;
                    boat.health = 3;
                    boat.Ability = "Missile";
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
