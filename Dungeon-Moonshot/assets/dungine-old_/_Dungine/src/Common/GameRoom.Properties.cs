/* Dungine: A game engine [v0.6.x.x] (https://github.com/CalistadalaneGames/dungine)
 *
 * FILE: Dungine.Common.GameRoom.Properties.cs
 * DESCRIPTION: Contains all components of a game.
 * AUTHOR: development@aprettycoolprogram.com
 *
 * This partial class is comprised of:
 *
 *  - Dungine.Common.GameRoom.cs            : Logic
 *  - Dungine.Common.GameRoom.Properties.cs : Property declarations
 *
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *
 * For more information, read the manual (https://github.com/CalistadalaneGames/dungine/doc/manual/dungine-manual.md)
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Dungine.Common
{
    public partial class GameRoom
    {
        /* This class defines the following room details:
         *
         *          Name: The name of the room (i.e. "Master bedroom")
         *   Description: The description of the room (i.e. "This bedroom has very ornate furniture.\n\nIt also smells musty!")
         *  RoomCardinal: Information about each of the room cardinals.
         *
         * Please refer to the Dungine documentation for more information.
         */


        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, GameCardinal> RoomCardinal { get; set; }


    }
}
