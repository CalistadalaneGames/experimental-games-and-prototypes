/*        ⠉⠕⠏⠽⠗⠊⠛⠓⠞⠼⠃⠼⠚⠼⠃⠼⠚⠁⠏⠗⠑⠞⠞⠽⠉⠕⠕⠇⠏⠗⠕⠛⠗⠁⠍⠁⠝⠙⠉⠁⠇⠊⠎⠞⠁⠙⠁⠇⠁⠝⠑⠛⠁⠍⠑⠎
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░      ░░░░░   ░░░░░   ░    ░░░░░   ░░░░     ░░░░░   ░    ░░░░░   ░         ░░░░░░
▒▒▒▒▒▒▒   ▒▒▒   ▒▒   ▒▒▒▒▒   ▒  ▒   ▒▒▒   ▒▒  ▒▒▒▒   ▒▒▒   ▒  ▒   ▒▒▒   ▒   ▒▒▒▒▒▒▒▒▒▒▒▒
▒▒▒▒▒▒▒   ▒▒▒▒   ▒   ▒▒▒▒▒   ▒   ▒   ▒▒   ▒  ▒▒▒▒▒▒▒▒▒▒▒   ▒   ▒   ▒▒   ▒   ▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▓▓▓▓▓   ▓▓▓▓   ▓   ▓▓▓▓▓   ▓   ▓▓   ▓   ▓   ▓▓▓▓▓▓▓▓▓▓   ▓   ▓▓   ▓   ▓       ▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓   ▓▓▓▓   ▓   ▓▓▓▓▓   ▓   ▓▓▓  ▓   ▓   ▓▓▓      ▓   ▓   ▓▓▓  ▓   ▓   ▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓   ▓▓▓   ▓▓   ▓▓▓▓▓   ▓   ▓▓▓▓  ▓  ▓▓   ▓▓▓▓  ▓▓▓   ▓   ▓▓▓▓  ▓  ▓   ▓▓▓▓▓▓▓▓▓▓▓▓
███████      ███████      ████   ██████   ███      █████   █   ██████   █         ██████
████████████████████████████████████████████████████████████████████████████████████████
                                                             ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    A game engine                                            ██░▄▄▀██░▄▄▄░██░▄▄▀██░▄▄▄██
    https://github.com/CalistadalaneGames/dungine            ██░█████░███░██░▀▀▄██░▄▄▄██
    Version 0.4.x                                            ██░▀▀▄██░▀▀▀░██░██░██░▀▀▀██
                                                             ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
    (C)2020 A Pretty Cool Program & Calistadalane Games.
    All rights reserved.
    Licensed under the Apache License v2 [https://apache.org/licenses/LICENSE-2.0]

    FILE:
    DESC:
    AUTHOR(S): development@aprettycoolprogram.com
 */

namespace DungineCore
{
    ////////////////public class Initializer
    ////////////////{
    ////////////////    /// <summary></summary>
    ////////////////    public static void VerifyRequirements()
    ////////////////    {
    ////////////////        if(!File.Exists("dungeon.json"))
    ////////////////        {
    ////////////////            DungeonObject.SaveToJson();
    ////////////////        }

    ////////////////        if(!File.Exists("parser.json"))
    ////////////////        {
    ////////////////            Parser.SaveToJson();
    ////////////////        }
    ////////////////    }

    ////////////////    /// <summary></summary>
    ////////////////    public static GameState PlayerStatus() => new GameState
    ////////////////    {
    ////////////////        PlayerIsAlive = true,
    ////////////////        PlayerIsInDungeon = true
    ////////////////    };

    ////////////////    public static DungeonObject DungeonData() => DungeonObject.LoadFromJson();

    ////////////////    public static Parser ParserData() => Parser.LoadFromJson();
    ////////////////}
}
