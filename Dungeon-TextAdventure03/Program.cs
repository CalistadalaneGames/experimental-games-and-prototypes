//  ▄▄▄▄▄▄  ▄▄   ▄▄ ▄▄    ▄ ▄▄▄▄▄▄▄ ▄▄▄ ▄▄    ▄ ▄▄▄▄▄▄▄
// █      ██  █ █  █  █  █ █       █   █  █  █ █       █
// █  ▄    █  █ █  █   █▄█ █   ▄▄▄▄█   █   █▄█ █    ▄▄▄█
// █ █ █   █  █▄█  █       █  █  ▄▄█   █       █   █▄▄▄
// █ █▄█   █       █  ▄    █  █ █  █   █  ▄    █    ▄▄▄█
// █       █       █ █ █   █  █▄▄█ █   █ █ █   █   █▄▄▄
// █▄▄▄▄▄▄██▄▄▄▄▄▄▄█▄█  █▄▄█▄▄▄▄▄▄▄█▄▄▄█▄█  █▄▄█▄▄▄▄▄▄▄█





using System.Text.Json;

namespace Dungeon_TextAdventure03
{
    internal class Program
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="args">Passed arguments.</param>
        private static void Main(string[] args)
        {
            var dungine = DungineCore.DungineObject.Build(5);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var jstring = JsonSerializer.Serialize(dungine, options);
            System.IO.File.WriteAllText("test.txt", jstring);
        }
    }
}