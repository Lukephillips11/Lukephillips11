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
            int nyMun = 12;


            Console.WriteLine("Hello! What is your name? ");
                givenName = Console.ReadLine();
            //Write string and add our variable that we stored
            // Console.WriteLine("Nice to meet you " + givenName);
            Console.WriteLine(String.Format("Hello {0}, how are you today? {1}", givenName, nyMun.ToString()));


            Console.WriteLine("I hope you are well");
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
            
        }
    }
}
