/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungine.TextAdventure.Game.Rooms.cs
 * Game components of the Dungine game engine for text adventures
 * https://github.com/CalistadalaneGames/dungine
 * Version 0.5.x.x
 * (C)2020 A Pretty Cool Program & Calistadalane Games.
 * All rights reserved.
 * Licensed under the Apache License v2 [https://apache.org/licenses/LICENSE-2.0]
 *
 * FILE:
 * DESC:
 * AUTHOR(S): development@aprettycoolprogram.com
 */

using System.Collections.Generic;

namespace Dungine.TextAdventure
{
    public partial class Game
    {
        public class Room
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public Cardinal RoomCardinals { get; set; }
        }

        public class Cardinal
        {
            public string ToRoomNumber { get; set; }
            public List<string> Actions { get; set; }
            public List<string> Objects { get; set; }
        }
    }
}
