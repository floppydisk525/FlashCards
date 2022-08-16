using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    internal class UserCommands
    {
        static internal void MainMenu()
        {
            bool closeApp = false;
            while (closeApp == false)
            {
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\nType 0 to Close Application.");
                Console.WriteLine("Type S to Manage Stacks");
                Console.WriteLine("Type F to Manage FlashCards");
                Console.WriteLine("Type R to Study");
                Console.WriteLine("Type V to View Study Session Date");

                string commandInput = Console.ReadLine();

                while (string.IsNullOrEmpty(commandInput))
                {
                    Console.WriteLine("\nInvalid Command.  Please enter a number from 0 to 4.\n");
                    commandInput = Console.ReadLine();
                }
                switch (commandInput)
                {
                    case "0":
                        closeApp = true;
                        Environment.Exit(0);
                        break;
                    case "S":
                        //codingController.Get();
                        break;
                    case "F":
                        //ProcessAdd();
                        break;
                    case "R":
                        //ProcessDelete();
                        break;
                    case "L":
                        //ProcessUpdate();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nInvalid Command.  Please type a number from 0 to 4.\n");
                        break;
                }
            }
        }
    }
}
