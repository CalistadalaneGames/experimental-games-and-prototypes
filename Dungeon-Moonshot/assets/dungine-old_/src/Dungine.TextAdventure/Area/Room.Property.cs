/* Dungine: A game engine [v0.7.x.x] (https://github.com/calistadalanegames/dungine)
 *
 * FILE: Dungine.TextAdventure.Area.Room.Properties.cs
 * DESCRIPTION: Property definitions for Dungine.TextAdventure.Area.Room.cs
 * AUTHOR: development@aprettycoolprogram.com
 *
 * This partial class is comprised of:
 *  - Dungine.TextAdventure.Area.Room.cs          : Logic
 *  - Dungine.TextAdventure.Area.Room.Property.cs : Property definitions
 *
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *
 * For more information, read the manual (https://github.com/calistadalanegames/dungine/doc/manual/dungine-manual.md)
 */

namespace Dungine.TextAdventure.Area
{
    public partial class Room
    {
        /// <include file='Room.xml' path='class/member[@name="Name"]/*'/>
        public string Name
        {
            get;
            set;
        }

        /// <include file='Room.xml' path='class/member[@name="Description"]/*'/>
        public string Description
        {
            get;
            set;
        }


        //public Dictionary<string, GameCardinal> RoomCardinal
        //{
        //    get;
        //    set;
        //}

    }
}
