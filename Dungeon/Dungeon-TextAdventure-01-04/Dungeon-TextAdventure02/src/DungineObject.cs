// Dungeon: Text Adventure 02
// Dungine.cs: The Dungine object.

using System.Collections.Generic;

namespace Dungeon_TextAdventure02
{
    public class DungineObject
    {
        public Dictionary<string, GameTextMessage> TextMessages;
        public Dictionary<int, GameRoom>           Room;

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

        public class GameRoom
        {
            public string Name
            {
                get; set;
            }
        }
    }
}
