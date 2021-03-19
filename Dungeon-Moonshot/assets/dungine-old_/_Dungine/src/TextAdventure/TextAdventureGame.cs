/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungine: A game engine. [https://github.com/CalistadalaneGames/dungine]
 * Version 0.6.x.x
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 [https://apache.org/licenses/LICENSE-2.0]
 *
 *        FILE: Dungine.TextAdventure.TextAdventureGame.cs
 * DESCRIPTION: The TextAdventureGame object for use with text adventure games.
 *      AUTHOR: development@aprettycoolprogram.com
 */

using System.Collections.Generic;

namespace Dungine.TextAdventure
{
    public class TextAdventureGame
    {
        public Common.Detail Details { get; set; }
        public Common.GameRule Rules { get; set; }
        public Common.GameState States { get; set; }
        public Dictionary<string, Common.GameMessage> Messages { get; set; }
        public Dictionary<string, Common.GameRoom> Rooms { get; set; }

        ////////public static TextAdventureGame New()
        ////////{
        ////////    VerifyComponents();

        ////////    var test = 0;
        ////////    test = test + 1;
        ////////    return new TextAdventureGame();
        ////////}

        ////////public static void VerifyComponents()
        ////////{
        ////////    if(!File.Exists("dungeon.json"))
        ////////    {
        ////////        File.WriteAllText("dungeon.json", "test");
        ////////    }

        ////////    if(!File.Exists("parser.json"))
        ////////    {
        ////////        File.WriteAllText("parser.json", "test");
        ////////    }
        ////////}

    }
}


//public class Initializer
//{
//    /// <summary></summary>
//    public static void VerifyRequirements()
//    {
//        if(!File.Exists("dungeon.json"))
//        {
//            DungeonObject.SaveToJson();
//        }

//        if(!File.Exists("parser.json"))
//        {
//            Parser.SaveToJson();
//        }
//    }

//    /// <summary></summary>
//    public static GameState PlayerStatus() => new GameState
//    {
//        PlayerIsAlive = true,
//        PlayerIsInDungeon = true
//    };

//    public static DungeonObject DungeonData() => DungeonObject.LoadFromJson();

//    public static Parser ParserData() => Parser.LoadFromJson();
//}
