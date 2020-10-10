/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungeon: The Evil Lair. [https://github.com/CalistadalaneGames/dungeon]
 * Version 0.0.0.0
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 [https://apache.org/licenses/LICENSE-2.0]
 *
 * FILE:
 * DESC:
 * AUTHOR(S): development@aprettycoolprogram.com
 */

using Dungine.InputOutput;

namespace Dungeon_TheEvilLair
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Dungine.Generic.GenericGame.NewTemplate();

            Dungine.Common.Game game = (Dungine.Common.Game)LoadData.Json("dungine_generic-game.json");

        }
    }
}
