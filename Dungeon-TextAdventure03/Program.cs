// Dungeon: Text Adventure 03
// Version 0.0.0
// https://github.com/CalistadalaneGames/experimental-games-and-prototypes
// (C)2020 A Pretty Cool Program & Calistadalane Games All rights reserved.
// Licensed under the Apache License v2

// Program.cs: Entry point for Dungeon: Text Adventure 03

using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Dungeon_TextAdventure03
{
    internal class Program
    {
        public static DungineCore.DungeonObject dungeonObject;
        public static DungineCore.Parser        parser;

        // TODO This may be moved to DungeonObject.
        public static string        currentRoom;
        public static bool          playerIsAlive;
        public static bool          playerIsInDungeon;

        /// <summary></summary>
        /// <param name="args">Passed arguments.</param>
        private static void Main(string[] args)
        {
            CheckGameRequirements();
            InitializeGame();
            WelcomeToTheGame();
            RoomLoop();
        }

        /// <summary></summary>
        private static void CheckGameRequirements()
        {
            if(!File.Exists("dungeon.json"))
            {
                DungineCore.Parser.SaveToJson();
                DungineCore.DungeonObject.SaveToJson();
            }
        }

        /// <summary></summary>
        private static void InitializeGame()
        {
            playerIsAlive     = true;
            playerIsInDungeon = true;

            dungeonObject = DungineCore.DungeonObject.LoadFromJson();
            parser        = DungineCore.Parser.LoadFromJson();
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
            currentRoom = "0";

            while(playerIsAlive && playerIsInDungeon)
            {
                EnterRoom(currentRoom);
            }

            if(!playerIsAlive)
            {
                // Do something
            }
            else if(!playerIsInDungeon)
            {
                // Do something
            }
            else
            {
                // Do something
            }
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

            while(!IsValidRoomAction(playerRequest))
            {
                var invalidEntryMessage = "\n\nThat's not possible." +
                                      "\n\n" +
                                      "What do you want to do? ";

                Console.Write(invalidEntryMessage);
                Console.Write(roomMessage);
                playerRequest = Console.ReadLine();
            }

            ParseRequest(playerRequest);



            //while(!IsValidCardinalAction(whatToDo))
            //{
            //    var invalidEntryMessage = "\n\nThat's not possible." +
            //                          "\n\n" +
            //                          "What do you want to do? ";

            //    Console.Write(invalidEntryMessage);
            //    Console.Write(roomMessage);
            //    whatToDo = Console.ReadLine();
            //}

            //Parser(whatToDo);

            var goingToRoom = "1";

            return goingToRoom;
        }

        /// <summary></summary>
        /// <param name="action"></param>
        public static void ParseRequest(string playerRequest)
        {





        }

        /// <summary></summary>
        /// <param name="whatToDo"></param>
        /// <returns></returns>
        public static bool IsValidRoomAction(string playerAction)
        {
            var action = "";

            if(parser.Actions.Any(playerAction.Contains))
            {
                action =
            }

            return action;
        }

        public static void ParseAction(string playerAction)
        {
            if(playerMove(playerAction))
            {

            }

            switch(playerAction.Any()
            {
                case "go":
                case "move":
                case "walk":
                    playerMove(playerAction);
                    break;

                default:
                    break;
            }
        }

        public static bool ActionIsMove(string playerAction)
        {
            return playerAction.Split(new[] { ' ' }).Any(parser.Cardinals.Contains);



        }


        public static bool IsValidCardinalAction(string whatToDo)
        {

            return true;
        }


        //public static bool IsValidCardinalAction(string whatToDo, string roomNumber)
        //{
        //   // System.Collections.Generic.Dictionary<string, DungeonObject.Cardinal> test = dungineObject.Rooms[roomNumber].Cardinals

        //    //if(true)
        //    //{
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}
        //}
    }
}

// ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎