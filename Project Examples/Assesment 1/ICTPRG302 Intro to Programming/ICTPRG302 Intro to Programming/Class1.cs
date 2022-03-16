using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ICTPRG302_Intro_to_Programming
{
    class Gamertags
    {
        // The list of gamer tags loaded from file
        private string[] gamerTagList = { };

        // Load a list of gamertags from file and store the
        //resulting list in out gamertagList

        public void LoadGamertags()
        {
            gamerTagList = File.ReadAllLines("../gamertags.txt");
        }
        // Display gamertags ending with a number
        public void PrintGamerTagsEndingWithNumbers()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Gamertags ending with a number");
            Console.WriteLine("====================");

            // loop over the list of gamertags and print each out on a new line
            int linenumber = 1; // this local variable is used as a "bullet list" counter for each line
            foreach (string s in gamerTagList)
            {


                // test each gamertag to ensure it has at least one character
                // And the last character in is a number
                // If both tests pass, then the "if" statment's body will execute
                if ((s.Length > 0) && char.IsNumber(s, s.Length - 1))
                {
                    // format a line for each gamertag with a number infront
                    // note: there are alternative memory-efficient methods to concatentate strings
                    Console.WriteLine(linenumber.ToString() + ") " + s);

                    linenumber = linenumber + 1;    // increment the linenumber for the next time around the loop
                }




                





                // Display a message to the user & wait for a keypress
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            }
        }
}
