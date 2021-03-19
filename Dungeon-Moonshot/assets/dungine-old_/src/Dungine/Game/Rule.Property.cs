/* Dungine: A game engine [v0.7.x.x] (https://github.com/calistadalanegames/dungine)
 *
 * FILE: Dungine.Game.Rule.Property.cs
 * DESCRIPTION: Proprty definitions for Dungine.Game.Rule.cs
 * AUTHOR: development@aprettycoolprogram.com
 *
 * This partial class is comprised of:
 *  - Dungine.Game.Rule.cs          : Logic
 *  - Dungine.Game.Rule.Property.cs : Property definitions
 *
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *
 * For more information, read the manual (https://github.com/calistadalanegames/dungine/doc/manual/dungine-manual.md)
 */

namespace Dungine.Game
{
    public partial class Rule
    {

        /// <include file='Rule.xml' path='class/member[@name="MinPlayer"]/*'/>
        public string MinPlayer
        {
            get;
            set;
        }

        /// <include file='Rule.xml' path='class/member[@name="MaxPlayer"]/*'/>
        public string MaxPlayer
        {
            get;
            set;
        }

        /// <include file='Rule.xml' path='class/member[@name="StartRoom"]/*'/>
        public string StartRoom
        {
            get;
            set;
        }

        /// <include file='Rule.xml' path='class/member[@name="EntranceRoom"]/*'/>
        public string EntranceRoom
        {
            get;
            set;
        }

        /// <include file='Rule.xml' path='class/member[@name="ExitRoom"]/*'/>
        public string ExitRoom
        {
            get;
            set;
        }
    }
}
