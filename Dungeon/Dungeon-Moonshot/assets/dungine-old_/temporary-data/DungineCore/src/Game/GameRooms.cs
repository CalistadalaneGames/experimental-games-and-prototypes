﻿/*        ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
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

namespace DungineCore.Game
{
    public class GameRooms
    {
        public class Room
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public Dictionary<string, Cardinal> Cardinals { get; set; }
        }

        public class Cardinal
        {
            public string ToRoomNumber { get; set; }
            public List<string> Actions { get; set; }
            public List<string> Objects { get; set; }
        }
    }
}