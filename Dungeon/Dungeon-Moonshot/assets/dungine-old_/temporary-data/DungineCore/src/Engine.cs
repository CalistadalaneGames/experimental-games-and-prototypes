/*        ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░      ░░░░░   ░░░░░   ░    ░░░░░   ░░░░     ░░░░░   ░    ░░░░░   ░         ░░░░░░
▒▒▒▒▒▒▒   ▒▒▒   ▒▒   ▒▒▒▒▒   ▒  ▒   ▒▒▒   ▒▒  ▒▒▒▒   ▒▒▒   ▒  ▒   ▒▒▒   ▒   ▒▒▒▒▒▒▒▒▒▒▒▒
▒▒▒▒▒▒▒   ▒▒▒▒   ▒   ▒▒▒▒▒   ▒   ▒   ▒▒   ▒  ▒▒▒▒▒▒▒▒▒▒▒   ▒   ▒   ▒▒   ▒   ▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▓▓▓▓▓   ▓▓▓▓   ▓   ▓▓▓▓▓   ▓   ▓▓   ▓   ▓   ▓▓▓▓▓▓▓▓▓▓   ▓   ▓▓   ▓   ▓       ▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓   ▓▓▓▓   ▓   ▓▓▓▓▓   ▓   ▓▓▓  ▓   ▓   ▓▓▓      ▓   ▓   ▓▓▓  ▓   ▓   ▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓   ▓▓▓   ▓▓   ▓▓▓▓▓   ▓   ▓▓▓▓  ▓  ▓▓   ▓▓▓▓  ▓▓▓   ▓   ▓▓▓▓  ▓  ▓   ▓▓▓▓▓▓▓▓▓▓▓▓
███████      ███████      ████   ██████   ███      █████   █   ██████   █         ██████
████████████████████████████████████████████████████████████████████████████████████████
                                                             ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    A game engine                                            ██░▄▄▀██░▄▄▄░██░▄▄▀██░▄▄▄██
    https://github.com/CalistadalaneGames/dungine            ██░█████░███░██░▀▀▄██░▄▄▄██
    Version 0.4.x                                            ██░▀▀▄██░▀▀▀░██░██░██░▀▀▀██
                                                             ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
    (C)2020 A Pretty Cool Program & Calistadalane Games.
    All rights reserved.
    Licensed under the Apache License v2 [https://apache.org/licenses/LICENSE-2.0]

    FILE:
    DESC:
    AUTHOR(S): development@aprettycoolprogram.com
 */

using System.IO;
using System.Reflection;
using System.Text.Json;

using DungineCore.Parser;

namespace DungineCore
{
    public class Engine
    {
        public AssemblyComponents AssemblyComponent { get; set; }
        public ParserData Parser { get; set; }
        public GameData Game { get; set; }

        /// <summary>
        ///
        /// </summary>
        public class AssemblyComponents // TODO Move this someplace else.
        {
            public Assembly AssemblyName { get; set; }
            public string DatabaseResourcePrefix { get; set; }
        }

        /// <summary>
        ///
        /// </summary>
        public class ParserData
        {
            public Parser.ParserActions Actions { get; set; }
            public Parser.ParserCardinals Cardinals { get; set; }
            public Parser.ParserObjects Objects { get; set; }
        }

        /// <summary>
        ///
        /// </summary>
        public class GameData
        {
            private Game.GameMessages Messages { get; set; }
            private Game.GameRooms Rooms { get; set; }
            private Game.GameRules Rules { get; set; }
            private Game.GameStates States { get; set; }
        }

        /// <summary>
        ///
        /// </summary>
        public Engine()
        {
            AssemblyComponent = new AssemblyComponents
            {
                AssemblyName = Assembly.GetExecutingAssembly(),
                DatabaseResourcePrefix = "DungineCore.Data.Database.Embedded." // TODO Make this static.
            };

            //var test = DungineCore.Parser.Parser.


            //var parserAsString = 


            //var npd = JsonSerializer.Deserialize<DungineCore.Parser.Parser>(parserAsString);

            ////////var parserJsonFile = File.ReadAllText("parser.json");
            ////////var npd = JsonSerializer.Deserialize<DungineCore.Parser.ParserActions>(parserJsonFile);


            //Parser = npd;
        }
    }
}