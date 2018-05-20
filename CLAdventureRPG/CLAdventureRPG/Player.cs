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

        public void LevelUp()
        {
            Level++;
            Console.WriteLine($"You are now level {this.Level}.");
            MaxHealth += 10;
            MaxMana += 10;
            MaxStamina += 10;
            Console.WriteLine($"Your maximum health is now {this.MaxHealth}");
            Console.WriteLine($"Your maximum mana is now {this.MaxMana}");
            Console.WriteLine($"Your maximum stamina is now {this.MaxStamina}");
            Health = MaxHealth;
            Mana = MaxMana;
            Stamina = MaxStamina;
        }

        public void Attack(Monster monster)
        {
            Console.WriteLine($"{this.Name} attacks the {monster.Name}!");
            monster.Health -= this.Damage;
            Console.WriteLine($"{monster.Name} now has {monster.Health} health remaining.");
            monster.CheckIfDead(this);
        }
        // Run()
        public void GoldCheck()
        {
            Console.WriteLine($"You have {this.Gold} gold.");
        }

        public void ExperienceCheck()
        {
            Console.WriteLine($"You have {this.Experience} xp.");
        }
    }
}
