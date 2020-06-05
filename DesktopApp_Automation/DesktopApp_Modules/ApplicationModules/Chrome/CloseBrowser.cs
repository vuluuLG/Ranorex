﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace DesktopApp_Modules.ApplicationModules.Chrome
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseBrowser recording.
    /// </summary>
    [TestModule("2fe35adf-b05b-4456-b5bf-b2478c438c6c", ModuleType.Recording, 1)]
    public partial class CloseBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DesktopApp_Modules.DesktopApp_ModulesRepository repository.
        /// </summary>
        public static global::DesktopApp_Modules.DesktopApp_ModulesRepository repo = global::DesktopApp_Modules.DesktopApp_ModulesRepository.Instance;

        static CloseBrowser instance = new CloseBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseBrowser()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseBrowser Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable repoVersionApp.
        /// </summary>
        [TestVariable("c33a7b58-c069-4176-98d7-9637f83d8b63")]
        public string repoVersionApp
        {
            get { return repo.repoVersionApp; }
            set { repo.repoVersionApp = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'ApplicationModules.Browser.NotepadPlusPlus786ReleaseNotepadP.Restore'.", repo.ApplicationModules.Browser.NotepadPlusPlus786ReleaseNotepadP.RestoreInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.ApplicationModules.Browser.NotepadPlusPlus786ReleaseNotepadP.Restore, 1000);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
