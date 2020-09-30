// Dungeon: Text Adventure 02
// Dungine.cs: The Dungine object.


using System.Collections.Generic;

namespace Dungeon_TextAdventure02
{
    public class DungineObject
    {
        public Dictionary<string, GameTextMessage> TextMessages;

        public class GameTextMessage
        {
            public string Header
            {
                get; set;
            }
            public string Subject
            {
                get; set;
            }
            public string Body
            {
                get; set;
            }
        }
    }
}
