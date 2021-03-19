/* Dungine: A game engine [v0.7.x.x] (https://github.com/calistadalanegames/dungine)
 *
 * FILE: Dungine.Game.Detail.Property.cs
 * DESCRIPTION: Property definitions for Dungine.Game.Detail.cs
 * AUTHOR: development@aprettycoolprogram.com
 *
 * This partial class is comprised of:
 *  - Dungine.Game.Detail.cs          : Logic
 *  - Dungine.Game.Detail.Property.cs : Property definitions
 *
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *
 * For more information, read the manual (https://github.com/calistadalanegames/dungine/doc/manual/dungine-manual.md)
 */

namespace Dungine.Game
{
    public partial class Detail
    {
        /// <include file='Detail.xml' path='class/member[@name="Title"]/*'/>
        public string Title
        {
            get;
            set;
        }

        /// <include file='Detail.xml' path='class/member[@name="SubTitle"]/*'/>
        public string SubTitle
        {
            get;
            set;
        }

        /// <include file='Detail.xml' path='class/member[@name="Genre"]/*'/>
        public string Genre
        {
            get;
            set;
        }
    }
}
