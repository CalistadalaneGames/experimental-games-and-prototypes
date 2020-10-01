//  ▄▄▄▄▄▄  ▄▄   ▄▄ ▄▄    ▄ ▄▄▄▄▄▄▄ ▄▄▄ ▄▄    ▄ ▄▄▄▄▄▄▄
// █      ██  █ █  █  █  █ █       █   █  █  █ █       █  Dungeon: Text Adventure 03
// █  ▄    █  █ █  █   █▄█ █   ▄▄▄▄█   █   █▄█ █    ▄▄▄█  Version 0.0.0
// █ █ █   █  █▄█  █       █  █  ▄▄█   █       █   █▄▄▄   https://github.com/CalistadalaneGames/experimental-games-and-prototypes
// █ █▄█   █       █  ▄    █  █ █  █   █  ▄    █    ▄▄▄█  (C)2020 A Pretty Cool Program & Calistadalane Games All rights reserved.
// █       █       █ █ █   █  █▄▄█ █   █ █ █   █   █▄▄▄   Licensed under the Apache License v2
// █▄▄▄▄▄▄██▄▄▄▄▄▄▄█▄█  █▄▄█▄▄▄▄▄▄▄█▄▄▄█▄█  █▄▄█▄▄▄▄▄▄▄█

// Program.cs: Entry point for Dungeon: Text Adventure 03

using System.Text.Json;

namespace Dungeon_TextAdventure03
{
    internal class Program
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="args">Passed arguments.</param>
        private static void Main(string[] args)
        {
            //var dungine = DungineCore.DungineObject.BuildFromScratch(5);

            var dungine = DungineCore.DungineObject.Build();

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var jstring = JsonSerializer.Serialize(dungine, options);
            System.IO.File.WriteAllText("test.txt", jstring);
        }
    }
}