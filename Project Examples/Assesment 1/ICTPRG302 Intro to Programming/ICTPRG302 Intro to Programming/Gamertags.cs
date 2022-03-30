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
        private List<string> gamerTagList = new List<string>();

        // Load a list of gamertags from file and store the
        //resulting list in out gamertagList

        public void LoadGamertags()
        {
            string[] temp = File.ReadAllLines("../gamertags.txt");
            foreach (string name in temp)
            {
                gamerTagList.Add(name);
            }
        }

        public void PrintAllGamertags()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Gamertags ending with a number");
            Console.WriteLine("====================");

            // loop over the list of gamertags and print each out on a new line
            int linenumber = 1; // this local variable is used as a "bullet list" counter for each line
            foreach (string s in gamerTagList)
            {

                    // format a line for each gamertag with a number infront
                    // note: there are alternative memory-efficient methods to concatentate strings
                    Console.WriteLine(linenumber.ToString() + ") " + s);

                    linenumber = linenumber + 1;    // increment the linenumber for the next time around the loop

            }

            //display a message & wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Display gamertags ending with a number
        public void PrintGamerTagsEndingWithNumber()
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

            }

            //display a message & wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void PrintGamerTagsNotStartingWithANumberOrLetter()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Gamertags not starting with a number or letter");
            Console.WriteLine("====================");

            // loop over the list of gamertags and print each out on a new line
            int linenumber = 1; // this local variable is used as a "bullet list" counter for each line
            foreach (string s in gamerTagList)
            {
                // test each gamertag to ensure it has at least one character
                // And the last character in is a number
                // If both tests pass, then the "if" statment's body will execute
                if ((s.Length > 0) && (char.IsLetterOrDigit(s,0) == false))
                {
                    // format a line for each gamertag with a number infront
                    // note: there are alternative memory-efficient methods to concatentate strings
                    Console.WriteLine(linenumber.ToString() + ") " + s);

                    linenumber = linenumber + 1;    // increment the linenumber for the next time around the loop
                }

            }

            //display a message & wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void AddName()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Enter new username");
            Console.WriteLine("====================");
            string newname = Console.ReadLine();
            if (newname.Length > 0)
            {
                gamerTagList.Add(newname);
                File.WriteAllLines("../gamertags.txt", gamerTagList);
            }

        }


    }

}




                
