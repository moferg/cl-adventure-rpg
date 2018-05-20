using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAdventureRPG
{
    public class Monster
    {
        public string Name = "Monster";
        public int Level = 1;
        public int GoldDrop = 10;
        public int ExperienceDrop = 10;
        public int Health = 50;
        // Armor
        public int Damage = 5;
        
        // Monster()
        public void Attack(Player player)
        {
            Console.WriteLine($"The {this.Name} attacks you!");
            player.Health -= this.Damage;
            Console.WriteLine($"You have {player.Health} health remaining.");
        }

        public void Die(Player player)
        {
            Console.WriteLine($"You killed the {this.Name}!");
            player.Gold += this.GoldDrop;
            player.Experience += this.ExperienceDrop;
        }

        public void CheckIfDead(Player player)
        {
            if (this.Health <= 0)
            {
                this.Die(player);
            }
        }
    }
}
