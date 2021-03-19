/* Dungine: A game engine [v0.7.x.x] (https://github.com/calistadalanegames/dungine)
 *
 * FILE: Dungine.Player.Inventory.Properties.cs
 * DESCRIPTION: Property definitions for Dungine.Player.Inventory.cs
 * AUTHOR: development@aprettycoolprogram.com
 *
 * This partial class is comprised of:
 *  - Dungine.Player.Inventory.cs          : Logic
 *  - Dungine.Player.Inventory.Property.cs : Property definitions
 *
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *
 * For more information, read the manual (https://github.com/calistadalanegames/dungine/doc/manual/dungine-manual.md)
 */

using System.Collections.Generic;

namespace Dungine.Player
{
    public partial class Inventory
    {
        /// <include file='Inventory.xml' path='class/member[@name="PaperDoll"]/*'/>
        public Equipped PaperDoll
        {
            get;
            set;
        }

        /// <include file='Inventory.xml' path='class/member[@name="Backpack"]/*'/>
        public List<string> Backpack
        {
            get;
            set;
        }

        /// <include file='Inventory.xml' path='class/member[@name="Equipped"]/*'/>
        public class Equipped
        {
            /// <include file='Inventory.xml' path='class/member[@name="Equipped.Head"]/*'/>
            public string Head
            {
                get;
                set;
            }

            /// <include file='Inventory.xml' path='class/member[@name="Equipped.Torso"]/*'/>
            public string Torso
            {
                get;
                set;
            }

            /// <include file='Inventory.xml' path='class/member[@name="Equipped.Leg"]/*'/>
            public string Leg
            {
                get;
                set;
            }

            /// <include file='Inventory.xml' path='class/member[@name="Equipped.Foot"]/*'/>
            public string Foot
            {
                get;
                set;
            }
        }
    }
}
