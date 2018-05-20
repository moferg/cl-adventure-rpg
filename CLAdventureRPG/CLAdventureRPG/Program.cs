using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAdventureRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Command Line Adventure RPG!");
            Console.WriteLine("Please enter your character's name.");
            string Name = Console.ReadLine();
            Player player = new Player(Name);

            Console.WriteLine($"Your name is {player.Name}.");
            Console.WriteLine($"You are level {player.Level}.");
            Console.WriteLine($"You have {player.Experience} xp.");

            Console.WriteLine("Press Enter to continue.");
            Console.ReadKey();

            Monster monster = new Monster();
            Console.WriteLine($"A wild {monster.Name} has appeared!");
            Console.WriteLine($"The {monster.Name} is Level {monster.Level}.");
            Console.WriteLine($"The {monster.Name} will give you {monster.ExperienceDrop} xp if you kill it.");

            Console.WriteLine("Press Enter to continue.");
            Console.ReadKey();

            Console.WriteLine("It is time for battle!");
            Console.WriteLine($"{monster.Name} has {monster.Health} health.");

            Console.WriteLine("Press Enter to attack.");
            Console.ReadKey();
            player.Attack(monster);
            monster.Attack(player);

            Console.WriteLine("Press Enter to attack.");
            Console.ReadKey();
            player.Attack(monster);
            monster.Attack(player);

            Console.WriteLine("Press Enter to attack.");
            Console.ReadKey();
            player.Attack(monster);
            monster.Attack(player);

            Console.WriteLine("Press Enter to attack.");
            Console.ReadKey();
            player.Attack(monster);
            monster.Attack(player);

            Console.WriteLine("Press Enter to attack.");
            Console.ReadKey();
            player.Attack(monster);
            monster.Attack(player);

            Console.WriteLine($"You now have {player.Gold} gold.");
            Console.WriteLine($"You now have {player.Experience} xp.");

            Console.WriteLine("Press Enter to exit.");
            Console.Read();
        }
    }
}
