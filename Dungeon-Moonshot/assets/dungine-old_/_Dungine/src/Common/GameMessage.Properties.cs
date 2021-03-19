/* Dungine: A game engine [v0.6.x.x] (https://github.com/CalistadalaneGames/dungine)
 *
 * FILE: Dungine.Common.GameMessage.Properties.cs
 * DESCRIPTION: Contains all components of a game.
 * AUTHOR: development@aprettycoolprogram.com
 *
 * This partial class is comprised of:
 *
 *  - Dungine.Common.Message.cs            : Logic
 *  - Dungine.Common.Message.Properties.cs : Property declarations
 *
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *
 * For more information, read the manual (https://github.com/CalistadalaneGames/dungine/doc/manual/dungine-manual.md)
 */

namespace Dungine.Common
{
    public partial class GameMessage
    {
        /* This class defines the following message details:
         *
         *  Subject: The subject of the message (i.e. "Welcome to the game!")
         *     Body: The body of the message (i.e. "This might be kind of scary!\nHave fun!")
         *
         * Please refer to the Dungine documentation for more information.
         */

        /// <include file='Development/GameMessage.xml' path='class/member[@name="Subject"]/*'/>
        public string Subject
        {
            get;
            set;
        }

        /// <include file='Development/GameMessage.xml' path='class/member[@name="Body"]/*'/>
        public string Body
        {
            get;
            set;
        }


    }
}
