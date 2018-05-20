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
        public bool IsAlive = true;
        
        // Monster()
        public void Attack(Player player)
        {
            if (IsAlive)
            {
                Console.WriteLine($"The {Name} attacks you!");
                player.Health -= Damage;
                Console.WriteLine($"You have {player.Health} health remaining.");
            }
        }

        public void Die(Player player)
        {
            IsAlive = false;
            Console.WriteLine($"You killed the {Name}!");
            player.Gold += GoldDrop;
            player.Experience += ExperienceDrop;
            player.GoldCheck();
            player.ExperienceCheck();
            if (player.Experience >= 100)
            {
                player.LevelUp();
            }
        }

        public void CheckIfDead(Player player)
        {
            if (Health <= 0)
            {
                Die(player);
            }
        }
    }
}
