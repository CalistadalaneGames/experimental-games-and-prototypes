/* Dungine: A game engine [v0.7.x.x] (https://github.com/calistadalanegames/dungine)
 *
 * FILE: Dungine.Player.State.Property.cs
 * DESCRIPTION: Proprty definitions for Dungine.Player.State.cs
 * AUTHOR: development@aprettycoolprogram.com
 *
 * This partial class is comprised of:
 *  - Dungine.Player.State.cs          : Logic
 *  - Dungine.Player.State.Property.cs : Property definitions
 *
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *
 * For more information, read the manual (https://github.com/calistadalanegames/dungine/doc/manual/dungine-manual.md)
 */

namespace Dungine.Player
{
    public partial class State
    {
        /// <include file='State.xml' path='class/member[@name="IsAlive"]/*'/>
        public bool IsAlive
        {
            get;
            set;
        }

        /// <include file='State.xml' path='class/member[@name="IsInDungeon"]/*'/>
        public bool IsInDungeon
        {
            get;
            set;
        }
    }
}
