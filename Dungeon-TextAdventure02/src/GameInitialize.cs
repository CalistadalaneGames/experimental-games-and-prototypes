// Dungeon: Text Adventure 02
// GameInitializer.cs: Initializes the components of a new game.

using System.Collections.Generic;

namespace Dungeon_TextAdventure02
{
    public class GameInitialize
    {
        public static void BuildGameMessages(DungineObject dungine)
        {
            List<string> messageNames = GetMessageNames();

            var msgNumber = 0;

            foreach(var messageName in messageNames)
            {
                var gm = new DungineObject.GameTextMessage
                {
                    Header  = "testHdr",
                    Subject = "testSub",
                    Body    = "testBod"
                };

                dungine.TextMessages.Add(messageName, gm);
            }

            var breaker=0;
        }

        public static List<string> GetMessageNames()
        {
            // TODO Eventually this should be in an external file.
            return new List<string>
            {
                "WelcomeToGame",
                "EntranceToDungeon",
                "Room01",
                "Room02",
                "Room03",
                "Room04",
                "Room05",
                "PlayerVictory",
                "PlayerDefeat"
            };
        }




    }
}
