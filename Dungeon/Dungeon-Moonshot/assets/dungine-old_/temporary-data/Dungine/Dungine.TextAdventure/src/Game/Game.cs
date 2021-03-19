/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungine.TextAdventure.Game.cs
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
using System.Security.Cryptography.X509Certificates;

namespace Dungine.TextAdventure
{
    public partial class Game
    {
        public Details Detail { get; set; }
        public Rules Rule { get; set; }
        public States State { get; set; }
        public Dictionary<string, Messages> Message { get; set; }
        public Dictionary<string, Room> Rooms { get; set; }

        public static Game New()
        {
            return new Game();
        }
    }
}
