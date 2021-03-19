/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungine: A game engine. [https://github.com/CalistadalaneGames/dungine]
 * Version 0.5.x.x
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 [https://apache.org/licenses/LICENSE-2.0]
 *
 * FILE: Dungine.Common.PlayerState.cs
 * DESC: Defines various player states.
 * AUTHOR(S): development@aprettycoolprogram.com
 */

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Dungine.Common
{
    public class PlayerState
    {
        /* This class defines the following player states:
         *
         *      IsAlive: Determines if the player is alive (i.e. "true")
         *  IsInDungeon: Determines if the player is still in the dungeon (i.e. "true")
         *    Inventory: The player's inventory (i.e. "axe", "red key", "rope")
         *
         * Please refer to the Dungine documentation for more information.
         */

        public List<string> Inventory { get; set; }
    }
}
