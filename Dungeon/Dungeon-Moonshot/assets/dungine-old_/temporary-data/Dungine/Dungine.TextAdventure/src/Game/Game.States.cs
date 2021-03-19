/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungine.TextAdventure.States.cs
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
namespace Dungine.TextAdventure
{
    public partial class Game
    {
        public class States
        {
            public Players Player { get; set; }
        }

        public class Players
        {
            public bool IsAlive { get; set; }
            public bool IsInDungeon { get; set; }
        }
    }
}
