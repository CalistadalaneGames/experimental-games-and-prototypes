/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungine: A game engine. [https://github.com/CalistadalaneGames/dungine]
 * Version 0.6.x.x
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 [https://apache.org/licenses/LICENSE-2.0]
 *
 *        FILE: Dungine.Common.GameInstance.Properties.cs
 * DESCRIPTION: Properties for the GameInstance object.
 *      AUTHOR: development@aprettycoolprogram.com
 *
 * This is a partial class comprised of:
 *
 *  - Dungine.Common.GameInstance.cs            : GameInstance logic
 *  - Dungine.Common.GameInstance.Properties.cs : GameInstance property declarations
 */

using System.Collections.Generic;

namespace Dungine.Common
{
    public partial class GameInstance
    {
        /// <include file='Development/GameDetail.xml' path='class/member[@name="GameDetail"]/*'/>
        public Detail Detail
        {
            get;
            set;
        }

        /// <include file='Development/GameRule.xml' path='class/member[@name="GameRule"]/*'/>
        public GameRule Rule
        {
            get;
            set;
        }

        /// <include file='Development/GameState.xml' path='class/member[@name="GameState"]/*'/>
        public GameState State
        {
            get;
            set;
        }

        /// <include file='Development/GameMessage.xml' path='class/member[@name="GameMessage"]/*'/>
        public Dictionary<string, GameMessage> Message
        {
            get;
            set;
        }

        /// <include file='Development/GameRoom.xml' path='class/member[@name="GameRoom"]/*'/>
        public Dictionary<string, GameRoom> Room
        {
            get;
            set;
        }
    }
}
