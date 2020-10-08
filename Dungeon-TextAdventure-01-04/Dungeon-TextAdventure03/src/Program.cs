// Dungeon: Text Adventure 03
// Version 0.0.0
// https://github.com/CalistadalaneGames/experimental-games-and-prototypes
// (C)2020 A Pretty Cool Program & Calistadalane Games All rights reserved.
// Licensed under the Apache License v2

// Program.cs: Entry point for Dungeon: Text Adventure 03

using System;
using System.Reflection;

namespace Dungeon_TextAdventure03
{
    internal class Program
    {
        public static DungineCore.GameState     gameState;
        public static DungineCore.DungeonObject dungeonObject;
        public static DungineCore.Parser        parser;

        /// <summary></summary>
        /// <param name="args">Passed arguments.</param>
        private static void Main(string[] args)
        {
            StartGame();
        }

        /// <summary></summary>
        private static void StartGame()
        {
            DungineCore.Initializer.VerifyRequirements();

            gameState     = DungineCore.Initializer.PlayerStatus();
            dungeonObject = DungineCore.Initializer.DungeonData();
            parser        = DungineCore.Initializer.ParserData();

            WelcomeToTheGame();
            RoomLoop();
        }

        /// <summary></summary>
        /// <param name="dungeonObject"></param>
        private static void WelcomeToTheGame()
        {
            Version gameVersion = Assembly.GetEntryAssembly().GetName().Version;
            Console.WriteLine($"  Dungeon: Text Adventure 03 v{gameVersion}\n\n");

            var msgPlayerWelcome = dungeonObject.Messages["MessageName"].Subject +
                                   "\n\n" +
                                   dungeonObject.Messages["MessageName"].Body;

            Console.Write(msgPlayerWelcome);

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

        /// <summary></summary>
        private static void RoomLoop()
        {
            var currentRoom = "0";


                if(currentRoom != "0")
                {
                    currentRoom = EnterRoom(currentRoom);
                }
                else
                {
                    currentRoom = EnterRoom("0");
                }

                EnterRoom(currentRoom);

        }

        /// <summary></summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public static string EnterRoom(string roomNumber)
        {
            var playerRequest = "";

            var roomMessage = "\n\nRoom: " + dungeonObject.Rooms[roomNumber].Name +
                      "\n\n" +
                      dungeonObject.Rooms[roomNumber].Description +
                      "\n\n" +
                      "What do you want to do? ";

            Console.Write(roomMessage);
            playerRequest = Console.ReadLine().ToLower();

            while(!parser.Actions.Contains(playerRequest))
            {
                var invalidEntryMessage = "\n\nThat's not possible." +
                                      "\n\n" +
                                      "What do you want to do? ";

                Console.Write(invalidEntryMessage);
                Console.Write(roomMessage);
                playerRequest = Console.ReadLine();
            }

            var goingToRoom = "";

            if(playerRequest == "go")
            {
                goingToRoom = dungeonObject.Rooms[roomNumber].Cardinals["north"].ToRoomNumber;
            }

            return goingToRoom;
        }
    }
}

// ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎