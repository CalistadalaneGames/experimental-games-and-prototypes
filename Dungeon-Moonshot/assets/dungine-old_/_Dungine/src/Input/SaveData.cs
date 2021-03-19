/* ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
 * Dungine: A game engine. [https://github.com/CalistadalaneGames/dungine]
 * Version 0.5.x.x
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 [https://apache.org/licenses/LICENSE-2.0]
 *
 * FILE: Dungine.InputOutput.SaveData.cs
 * DESC: Saves data.
 * AUTHOR(S): development@aprettycoolprogram.com
 */

using System.IO;
using System.Text.Json;
using Dungine.Common;

namespace Dungine.InputOutput
{
    public class SaveData
    {
        /// <summary>
        /// Save data as formatted JSON.
        /// </summary>
        /// <param name="filePath">The path of the file to save.</param>
        /// <param name="jsonData">The JSON data to save.</param>
        public static void IndentedJson(string filePath, object jsonData)
        {
            var jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var jsonString = JsonSerializer.Serialize(jsonData, jsonOptions);

            File.WriteAllText(filePath, jsonString);


        }

        /// <summary>
        /// Save data as minimized JSON.
        /// </summary>
        /// <param name="filePath">The path of the file to save.</param>
        /// <param name="jsonData">The JSON data to save.</param>
        public static void MinimizedJson(string filePath, object jsonData)
        {
            var jsonString = JsonSerializer.Serialize(jsonData);

            File.WriteAllText(filePath, jsonString);
        }
    }
}