﻿// Dungeon: Text Adventure 02
// Prototype/experimental text game engine (DungineTxt v0.0.2)
// Program.cs: Main entry point.

using System.Collections.Generic;

namespace Dungeon_TextAdventure02
{
    public class Program
    {
        public DungineObject Dungine;

        private static void Main(string[] args) => StartGame();

        public static void StartGame()
        {
            var Dungine = new DungineObject
            {
                TextMessages = new Dictionary<string,DungineObject.GameTextMessage>()
            };

            GameInitialize.BuildDungineObject(Dungine);
        }
    }
}
