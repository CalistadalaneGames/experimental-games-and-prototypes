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

namespace DungineCore.Parser
{
    public class ParserCardinals
    {
        public List<string> Cardinal { get; set; }

        public static List<string> BuildValidCardinals() => new List<string>
        {
            // TODO This list is tied to the game engine logic, and users should not be able to modify it. Eventually
            // this should be stored in an embedded data file.
            "north",
            "east",
            "south",
            "west"
        };
    }
}