// ===========================================================================================================  9:36 AM
//    FILENAME: MainWindow.xaml.cs
//       BUILD: 20191028
//     PROJECT: Dungeons_MemoriesOfTheAncients (https://github.com/APrettyCoolProgram/Dungeons_MemoriesOfTheAncients)
//     AUTHORS: development@aprettycoolprogram.com
//   COPYRIGHT: Copyright 2019 A Pretty Cool Program
//     LICENSE: Apache License, Version 2.0
// ====================================================================================================================

/* This is the main window/code of the project.
 */
using System.Windows;

namespace Dungeons_MemoriesOfTheAncients
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DevMode.LaunchThenQuit(false);
            DevMode.Testing(false);
            Setup();
            Start();
        }

        /// <summary>
        /// Applies customizations to the Main() window when the application launches.
        /// </summary>
        private void Setup()
        {
            SetupControls();
            SetupWindow();
        }

        /// <summary>
        ///
        /// </summary>
        private void SetupControls()
        {
            /* Any control customizations go here.
             */
        }

        /// <summary>
        /// Applies customizations to the Main() window when the application launches.
        /// </summary>
        private void SetupWindow()
        {
            /* Any window customizations go here.
             */
        }

        /// <summary>
        /// Initializes a project.
        /// </summary>
        private void Start()
        {
            /* Initialization code goes here.
             */

            var g = new DUNGINE.MainWindow();
            g.Show();

        }
    }
}