// Dungeon: Text Adventure 01
//
// Prototype/experimental text engine game.
//

using System;
using System.Reflection;

namespace Dungeon_TextAdventure01
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeToTheGame();
            EnterTheDungeon();
            Room01();
        }

        private static void WelcomeToTheGame()
        {
            var gameVersion = Assembly.GetEntryAssembly().GetName().Version;

            var welcomeMsg = $"\nWelcome to Dungeon: Text Adventure 01! (v{gameVersion})\n" +
                              "\nIn this game, you will explore a creepy dungeon." +
                              "\n\nKeep your wits about you, and be afraid of the dark!" +
                              "\n\nAre you sure you want to play? [Y/n] ";

            Console.Write(welcomeMsg);
            var wantToPlayResponse = Console.ReadLine();

            if(wantToPlayResponse == "Y" || wantToPlayResponse == "y")
            {
                Console.WriteLine("\nOk! Let's play!");
            }
            else
            {
                Console.WriteLine("\nOk! Maybe some other time!");
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        private static void EnterTheDungeon()
        {
            var entranceMsg = "\nYou are standing outside a creepy looking dungeon." +
                              "\n\nDo you want to enter the creepy dungeon? [Y/n] ";

            Console.Write(entranceMsg);
            var wantToEnterResponse = Console.ReadLine();

            if(wantToEnterResponse == "Y" || wantToEnterResponse == "y")
            {
                Console.WriteLine("\nOk! We are going in!");
            }
            else
            {
                Console.WriteLine("\nWhelp, I guess you just aren't cut out for adventuring.");
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        private static void Room01()
        {
            var entranceMsg = "\nThis place certianly is creepy!." +
                              "\n\nWhat do you want to do? ";

            var lookMsg = "\nYou are standing in a creepy, moldy room." +
                          "\nThere is a room to the north." +
                          "\nWhat do you want to do? ";

            var goNorthMsg = "\nYou are in a room with a giant dragon!" +
                             "\nBefore you can draw your blade, the dragon kills you!" +
                             "\nYou will be remembered as a great adventurer!" +
                             "\n\nThanks for playing!";

            var invalidChoiceMsg = "\nThat is an invalid choice!" +
                                   "\n\nWhat do you want to do? ";

            Console.Write(entranceMsg);
            var whatToDoResponse = Console.ReadLine();

            var playerIsAlive = true;

            while(playerIsAlive)
            {
                switch(whatToDoResponse.ToLower())
                {
                    case "look":
                        Console.Write(lookMsg);
                        break;

                    case "go north":
                        Console.Write(goNorthMsg);
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write(invalidChoiceMsg);
                        break;
                }

                whatToDoResponse = Console.ReadLine();
            }
        }
    }
}
