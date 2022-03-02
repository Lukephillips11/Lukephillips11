using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int health = 90;
              int healthBonus = 10;
              Console.WriteLine("You have " + health + " health ");
              health +=
                  health + healthBonus;
              Console.WriteLine("You have " + health + " health");
              Console.ReadKey(); */
            int score = 0;
            int pointValue = 5;
            int combo = 5;
            //Start of the game
            combo++;
            Console.WriteLine("The player's score is: " + score + " points");
            score += pointValue * combo;
            Console.WriteLine("You scored! new score is: " + score + " points");
            combo++;
            score += pointValue * combo;   
            Console.WriteLine("You scored! new score is: " + score + " points");
            Console.ReadKey();
        }
    }
}
