/* PROJECT: Dungeon.Moonshot (https://github.com/calistadalanegames/Dungeon.Moonshot)
 *    FILE: Dungeon.Moonshot.StartWindow.xaml.cs
 * UPDATED: 11-9-2020-3:50 PM
 * LICENSE: Apache v2 (https://apache.org/licenses/LICENSE-2.0)
 *          Copyright 2020 A Pretty Cool Program & Calistadalane Games
 *          All rights reserved
 */

/* Starts Dungeon: Moonshot.
 */

using System.Collections.Generic;
using System.Windows;

namespace Dungeon.Moonshot
{
    public partial class StartWindow : Window
    {
        /// <include file='StartWindow.comment.xml' path='class/member[@name="StartWindow"]/*'/>
        public StartWindow()
        {
            //ShowSplashScreen();
            DisplayDevelopmentLogos();
            StartGame();

            Du.Core.Terminate.ApplicationEnvironment();
        }

        /// <include file='StartWindow.comment.xml' path='class/member[@name="ShowSplashScreen"]/*'/>
        private void DisplayDevelopmentLogos()
        {
            var developmentLogosFilePaths = new List<string>()
            {
                "apcp-logo-250x250.png",
                "crispy-logo-250x250.png",
                "cg-logo-250x250.png"
            };


            // TODO: Add logic for DevelopedByOther splash screen.
            var developmentLogos = new Dungine.WPF.Splash.DevLogos(developmentLogosFilePaths);
            //developmentLogos.GetDevelopmentLogos();


            developmentLogos.ShowDialog();
        }



        /// <include file='StartWindow.comment.xml' path='class/member[@name="ShowSplashScreen"]/*'/>
        private void ShowSplashScreen()
        {
            // TODO: Add logic for DevelopedByOther splash screen.
            //var splashScreen = new Dungine.WPF.Splash.DevelopedByApcp();
            //splashScreen.ShowDialog();
        }

        /// <include file='StartWindow.comment.xml' path='class/member[@name="ShowSplashScreen"]/*'/>
        private void StartGame()
        {
            var gamePlaymat = new Dungine.WPF.Playmat.Playmat600();
            gamePlaymat.ShowDialog();
        }
    }
}

/* AUTHORS
 *  development @aprettycoolprogram.com
 */

