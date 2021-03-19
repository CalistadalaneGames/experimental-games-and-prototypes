// ====================================================================================================================
//    FILENAME: DevMode.cs
//       BUILD: 20191028
//     PROJECT: Dungeons_MemoriesOfTheAncients (https://github.com/APrettyCoolProgram/Dungeons_MemoriesOfTheAncients)
//     AUTHORS: development@aprettycoolprogram.com
//   COPYRIGHT: Copyright 2019 A Pretty Cool Program
//     LICENSE: Apache License, Version 2.0
// ====================================================================================================================

/* Development Mode code.
 */
using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace Dungeons_MemoriesOfTheAncients
{
    public class DevMode
    {
        /// <summary>
        /// Launch myAvatool, do something, then quit.
        /// </summary>
        /// <param name="enabled">[true, false]</param>
        public static void LaunchThenQuit(bool enabled)
        {
            /* There may be cases that you want to build external resources prior to actually running your project, and
            * that's what this method is for. DevMode.LaunchThenQuit() will do whatever is added here, then quit
            * the project before going any farther. For this to work, you'll need to have "DevMode.LaunchThenQuit()"
            * immediately after "InitializeComponent()" in the Main.cs constructor.
            */
            if (enabled)
            {
                /* We'll create a default game.json file that contains all of the information about this particular
                 * game.
                 */
                var initializeGameDetails = new DUNGINE.Core.Game
                {
                    Table = new DUNGINE.Core.GameTable
                    {
                        Resize    = ResizeMode.NoResize,
                        BackColor = Color.AliceBlue,
                        Style     = WindowStyle.SingleBorderWindow,
                        Height    = 500,
                        Width     = 1000
                    }
                };

                File.WriteAllText("tester.test", JsonSerializer.Serialize<DUNGINE.Core.Game>(initializeGameDetails));

                Environment.Exit(0);
            }
        }

        /// <summary>
        /// myAvatool testing procedures.
        /// </summary>
        /// <param name="enabled">[true, false]</param>
        public static void Testing(bool enabled)
        {
            /* Code here will execute each time your application is launched.
             */
            if (enabled)
            {
                // If you are using Du, you can just uncomment this line.
                // Du.DuTest();

                // Otherwise...TESTING CODE GOES HERE.
            }
        }

        /// <summary>
        /// DevMode Action Button events.
        /// </summary>
        public static void ActionButton(int btnNumber)
        {
            /* While developing your app, you can create "DevMode Action Buttons that, when clicked, will do something
             * related to testing and/or development. One example is if you want to test what should happen when an
             * event fires, but you don't want to create the UI yet.
             *
             * You can either have the Action Button event handler contain code that will eventually make its way to
             * the final UI, or call "DevMode.ActionButton(01)", which will do whatever the code in this method says.
             *
             * You can have any number of DevMode action buttons, and can reuse them for different testing purposes.
             */
            switch (btnNumber)
            {
                case 01:
                    // Your code goes here.
                    break;

                default:
                    break;
            }
        }
    }
}