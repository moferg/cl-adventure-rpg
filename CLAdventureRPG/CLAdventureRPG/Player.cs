using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAdventureRPG
{
    public class Player
    {
        public string Name = "";
        public int Experience = 0;
        public int Level = 1;
        public int Gold = 0;
        // Inventory
        public int MaxHealth = 100;
        public int Health = 100;
        public int MaxMana = 100;
        public int Mana = 100;
        public int MaxStamina = 100;
        public int Stamina = 100;
        // Armor
        public int Damage = 10;
        // IsAlive

        public Player(string name)
        {
            Name = name;
        }
        // LevelUp()
        public void Attack(Monster monster)
        {
            monster.Health -= this.Damage;
        }
        // Run()
    }
}
