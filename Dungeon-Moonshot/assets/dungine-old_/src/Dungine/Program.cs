/* Dungine: A game engine [v0.7.x.x] (https://github.com/calistadalanegames/dungine)
 *
 * FILE: Dungine.Program.cs
 * DESCRIPTION: Main entry point for Dungine.
 * AUTHOR: development@aprettycoolprogram.com
 *
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *
 * For more information, read the manual (https://github.com/calistadalanegames/dungine/doc/manual/dungine-manual.md)
 */

using System.Collections.Generic;

namespace Dungine
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the entry point for Dungine, and is currently not used.
        }

        /*  Eventually these tests should be moved to a proper testing solution.
         *
         *  This is mostly to verify the external comment files are working.
         */
        static private void ForTesting()
        {
            Game.Detail testGameDetailObject;

            testGameDetailObject = new Game.Detail
            {
                Title = "Test Title",
                SubTitle = "Test SubTitle",
                Genre = "test-genre"
            };

            Game.Rule testGameRuleObject;

            testGameRuleObject = new Game.Rule
            {
                MinPlayer = "1",
                MaxPlayer = "5",
                StartRoom = "0",
                EntranceRoom = "1",
                ExitRoom = "3"
            };

            TextAdventure.Area.Room testTextAdventureRoomObject;

            testTextAdventureRoomObject = new TextAdventure.Area.Room
            {
                Name = "Master bedroom",
                Description = "A simple bedroom with a bed, a desk, and a chair."
            };

            Player.State testPlayerStateObject;

            testPlayerStateObject = new Player.State
            {
                IsAlive = true,
                IsInDungeon = true
            };

            Player.Inventory testPlayerInventoryObject;

            testPlayerInventoryObject = new Player.Inventory
            {
                PaperDoll = new Player.Inventory.Equipped
                {
                    Head = "Helmet",
                    Torso = "Shirt",
                    Leg = "Pants",
                    Foot = "Boots"
                },
                Backpack = new List<string>
                {
                    "Water",
                    "Blanket",
                    "Red key"
                }
            };
        }
    }
}
