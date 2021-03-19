/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungine: A game engine. [https://github.com/CalistadalaneGames/dungine]
 * Version 0.5.x.x
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 [https://apache.org/licenses/LICENSE-2.0]
 *
 * FILE: Dungine.InputOutput.LoadGameInstance.cs
 * DESC: Loads an existing GameInstance from a file.
 * AUTHOR(S): development@aprettycoolprogram.com
 */

using System.IO;
using System.Text.Json;

using Dungine.Common;

namespace Dungine.InputOutput
{
    public class LoadGameInstance
    {
        ///// <summary>
        ///// Load JSON data
        ///// </summary>
        ///// <param name="filePath">The path of the JSON file to load.</param>
        ///// <returns>The JSON object.</returns>
        ///// 

        /// <include file='code-comments.xml' path='docs/members[@name="GameInstance"]/*'/>
        public static GameInstance Json(string filePath)
        {
            var gameInstance = new GameInstance();

            if(File.Exists(filePath))
            {
                var jsonFile = File.ReadAllText(filePath + ".json");

                gameInstance = JsonSerializer.Deserialize<GameInstance>(jsonFile);
            }

            return gameInstance;
        }
    }
}
