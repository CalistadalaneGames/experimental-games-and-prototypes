/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungeon: The Evil Lair. [https://github.com/CalistadalaneGames/dungeon]
 * Version 0.0.0.0
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 [https://apache.org/licenses/LICENSE-2.0]
 *
 * FILE: Program.cs
 * DESC: The entry point for Dungeon: The Evil Lair
 * AUTHOR(S): development@aprettycoolprogram.com
 */

using Dungine.Common;
using Dungine.InputOutput;

namespace Dungeon_TheEvilLair
{
    internal class Program
    {
        public static GameInstance Game;

        // Entry point.
        private static void Main(string[] args)
        {
            StartGame();

        }

        /// <include file='code-comments.xml' path='docs/members[@name="Program"]/StartGame/*'/>
        private static void StartGame()
        {
            CreateGenericGameInstance();

            LoadGame("dungeon_the-evil-lair");
        }



        /// <summary>
        /// Create a generic GameInstance JSON file.
        /// This is another line.
        /// And another
        /// </summary>
        /// <remarks>
        /// When a Dungine game starts, the first thing it does is create a generic GameInstance template because:\n
        /// If the "<gameName>.json" file for your game isn't found, the "dungine-generic-game.json" file is
        /// loaded.You'll find out pretty quick that something is wrong.
        /// The generic GameInstance template is useful when developing/debugging Dungine, and this way a new,
        /// current GameInstance template is created whenever a Dungine game is launched.
        /// For the most part, you can just ignore the ""dungine-generic-game.json" file.
        /// </remarks>
        private static void CreateGenericGameInstance()
        {
            GameInstance.NewTemplate();
        }
        /// <summary>
        /// This
        /// </summary>
        /// <param name="gameName"></param>

        public static void LoadGame(string gameName)
        {
            GameInstance Game = LoadGameInstance.Json(gameName);
        }

    }
}
