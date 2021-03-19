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

using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DungineCore.Parser
{
    public class Parser
    {
        public List<string> Actions { get; set; }
        public List<string> Cardinals { get; set; }
        public List<string> Objects { get; set; }

        public static string Initializer(Assembly assemblyName, string databaseResourcePrefix)
        {
            string parserAsString;

            using(Stream parserStream = assemblyName.GetManifestResourceStream(databaseResourcePrefix + "parser.dungine"))
            using(var parserStreamReader = new StreamReader(parserStream))
            {
                parserAsString = parserStreamReader.ReadToEnd();
            }

            return parserAsString;
        }
    }
}
