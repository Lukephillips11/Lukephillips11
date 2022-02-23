using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string givenName;
            Console.WriteLine("Hello! What is your name? ");
                givenName = Console.ReadLine();

            Console.WriteLine("Nice to meet you " + givenName);
            Console.WriteLine("I hope you are well");
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
