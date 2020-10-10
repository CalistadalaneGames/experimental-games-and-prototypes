/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungeon: The Evil Lair. [https://github.com/CalistadalaneGames/dungeon]
 * Version 0.0.0.0
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 [https://apache.org/licenses/LICENSE-2.0]
 *
 * FILE: Program.cs
 * DESC: The entry point for Dungeon: The Evil Lair
 * AUTHOR(S): development@aprettycoolprogram.com
 */

using Dungine.Common;
using Dungine.InputOutput;

namespace Dungeon_TheEvilLair
{
    internal class Program
    {
        public static GameInstance Game;

        private static void Main(string[] args)
        {
            /* DEBUGGING/DEVELOPMENT
             * Uncomment the following line and pass:
             *      "": don't do anything (default action)
             *  create: create a new Game template JSON file
             *    load: load a Game template JSON file.
             */
            DevelopmentAndDebug();
        }

        /// <summary>
        /// Executes some code for development/debugging purposes.
        /// </summary>
        /// <param name="action">The development/debugging action to take ["" (default), "create", "load"]</param>
        private static void DevelopmentAndDebug(string action = "")
        {
            switch(action)
            {
                case "create":
                    GameInstance.NewTemplate();
                    break;

                case "load":
                    Game = (GameInstance)LoadData.Json("dungine_generic-game.json");
                    break;

                default:
                    // Don't do anything.
                    break;
            }
        }
    }
}
