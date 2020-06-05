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

namespace DesktopApp_Modules.ApplicationModules.ControlPanel
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UninstallApp recording.
    /// </summary>
    [TestModule("bcf63e84-8b93-4423-b0c1-45fbe12d487c", ModuleType.Recording, 1)]
    public partial class UninstallApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DesktopApp_Modules.DesktopApp_ModulesRepository repository.
        /// </summary>
        public static global::DesktopApp_Modules.DesktopApp_ModulesRepository repo = global::DesktopApp_Modules.DesktopApp_ModulesRepository.Instance;

        static UninstallApp instance = new UninstallApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UninstallApp()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UninstallApp Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'ApplicationModules.ControlPanel.ProgramsAndFeatures.NotepadPlusPlus64BitX64' at 80;10.", repo.ApplicationModules.ControlPanel.ProgramsAndFeatures.NotepadPlusPlus64BitX64Info, new RecordItemIndex(0));
            repo.ApplicationModules.ControlPanel.ProgramsAndFeatures.NotepadPlusPlus64BitX64.Click(System.Windows.Forms.MouseButtons.Right, "80;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.ControlPanel.Explorer.Uninstall' at 44;15.", repo.ApplicationModules.ControlPanel.Explorer.UninstallInfo, new RecordItemIndex(1));
            repo.ApplicationModules.ControlPanel.Explorer.Uninstall.Click("44;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.ControlPanel.NotepadPlusPlusV786Uninstall.ButtonUninstall' at 25;7.", repo.ApplicationModules.ControlPanel.NotepadPlusPlusV786Uninstall.ButtonUninstallInfo, new RecordItemIndex(2));
            repo.ApplicationModules.ControlPanel.NotepadPlusPlusV786Uninstall.ButtonUninstall.Click("25;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.ControlPanel.NotepadPlusPlusV786Uninstall1.ButtonNo' at 40;14.", repo.ApplicationModules.ControlPanel.NotepadPlusPlusV786Uninstall1.ButtonNoInfo, new RecordItemIndex(3));
            repo.ApplicationModules.ControlPanel.NotepadPlusPlusV786Uninstall1.ButtonNo.Click("40;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.ControlPanel.NotepadPlusPlusV786Uninstall.ButtonClose' at 38;10.", repo.ApplicationModules.ControlPanel.NotepadPlusPlusV786Uninstall.ButtonCloseInfo, new RecordItemIndex(4));
            repo.ApplicationModules.ControlPanel.NotepadPlusPlusV786Uninstall.ButtonClose.Click("38;10");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
