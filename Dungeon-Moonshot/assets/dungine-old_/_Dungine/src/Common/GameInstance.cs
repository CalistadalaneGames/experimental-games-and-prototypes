/* Dungine: A game engine [v0.6.x.x] (https://github.com/CalistadalaneGames/dungine)
 *
 * FILE: Dungine.Common.GameInstance.cs
 * DESCRIPTION: Contains all components of a game.
 * AUTHOR: development@aprettycoolprogram.com
 *
 * This partial class is comprised of:
 *
 *  - Dungine.Common.GameDetail.cs            : Logic
 *  - Dungine.Common.GameDetail.Properties.cs : Property declarations
 *
 * (C)2020 A Pretty Cool Program & Calistadalane Games. All rights reserved.
 * Licensed under Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *
 * For more information, read the manual (https://github.com/CalistadalaneGames/dungine/doc/manual/dungine-manual.md)
 */

using System.Collections.Generic;
using System.IO;
using Dungine.InputOutput;

namespace Dungine.Common
{
    /// <include file='Development/GameInstance.xml' path='class/member[@name="GameInstance"]/*'/>
    public partial class GameInstance
    {

        /// <include file='Development/GameInstance.xml' path='class/member[@name="NewTemplate"]/*'/>
        public static void NewTemplate()
        {
            if(!File.Exists("dungine_generic-game.json"))
            {
                File.Delete("dungine_generic-game.json");
            }

            GameInstance gameTemplate = CreateTemplate();

            SaveData.IndentedJson("dungine_generic-game.json", gameTemplate);
        }

        /// <include file='Development/GameInstance.xml' path='class/member[@name="CreateTemplate"]/*'/>
        public static GameInstance CreateTemplate()
        {
            return new GameInstance
            {
                Detail = new Detail
                {
                    Title = "Game Title:",
                    SubTitle = "Game Subtitle",
                    Genre = "Generic"
                },
                Rule = new GameRule
                {
                    StartingRoom = "0",
                    EntranceRoom = "1",
                    ExitRoom = "2"
                },
                State = new GameState
                {
                    IsHappening = true
                },
                Message = new Dictionary<string, GameMessage>
                {
                    {
                        "Welcome",
                        new GameMessage
                        {
                            Subject = "Welcome to the game!",
                            Body = "Have fun!"
                        }
                    },
                    {
                        "Goodbye",
                        new GameMessage
                        {
                            Subject = "Goodbye!",
                            Body = "See you later!"
                        }
                    }
                },
                Room = new Dictionary<string, GameRoom>
                {
                    {
                        "0",
                        new GameRoom
                        {
                            Name = "The starting room",
                            Description = "An empty room",
                            RoomCardinal = new Dictionary<string, GameRoom.Cardinal>
                            {
                                {
                                    "north",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "1",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                },
                                {
                                    "east",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "none",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                },
                                {
                                    "south",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "none",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                },
                                {
                                    "west",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "none",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                }
                            }
                        }
                    },
                    {
                        "1",
                        new GameRoom
                        {
                            Name = "The entrance",
                            Description = "The dungeon entrance!",
                            RoomCardinal = new Dictionary<string, GameRoom.Cardinal>
                            {
                                {
                                    "north",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "2",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                },
                                {
                                    "east",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "none",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                },
                                {
                                    "south",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "entrance",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                },
                                {
                                    "west",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "none",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                }
                            },
                        }
                    },
                    {
                        "2",
                        new GameRoom
                        {
                            Name = "The exit room",
                            Description = "The dungeon exit!",
                            RoomCardinal = new Dictionary<string, GameRoom.Cardinal>
                            {
                                {
                                    "north",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "exit",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                },
                                {
                                    "east",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "none",
                                        Actions=new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                },
                                {
                                    "south",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "1",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                },
                                {
                                    "west",
                                    new GameRoom.Cardinal
                                    {
                                        ToRoomNumber = "none",
                                        Actions = new List<string>
                                        {
                                            "go",
                                            "take"
                                        },
                                        Objects = new List<string>
                                        {
                                            "door",
                                            "table"
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }



    }
}