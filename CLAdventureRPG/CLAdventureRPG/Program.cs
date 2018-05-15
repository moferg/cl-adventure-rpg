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
            Console.Read();
        }
    }
}
