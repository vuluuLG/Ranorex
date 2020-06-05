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

namespace DesktopApp_Modules.ApplicationModules.Notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InstallApp recording.
    /// </summary>
    [TestModule("5c2fb7c1-bef7-495e-8078-58f859991342", ModuleType.Recording, 1)]
    public partial class InstallApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DesktopApp_Modules.DesktopApp_ModulesRepository repository.
        /// </summary>
        public static global::DesktopApp_Modules.DesktopApp_ModulesRepository repo = global::DesktopApp_Modules.DesktopApp_ModulesRepository.Instance;

        static InstallApp instance = new InstallApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InstallApp()
        {
            varStartApp = "D:\\npp.7.8.6.Installer.x64.exe";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InstallApp Instance
        {
            get { return instance; }
        }

#region Variables

        string _varStartApp;

        /// <summary>
        /// Gets or sets the value of variable varStartApp.
        /// </summary>
        [TestVariable("63b67a07-fb9f-4e4b-9fa4-7ec2b13592a1")]
        public string varStartApp
        {
            get { return _varStartApp; }
            set { _varStartApp = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $varStartApp in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(varStartApp, "", "", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", varStartApp, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.Notepad.ButtonOK' at 34;11.", repo.ApplicationModules.Notepad.ButtonOKInfo, new RecordItemIndex(2));
            repo.ApplicationModules.Notepad.ButtonOK.Click("34;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.Notepad.ButtonNext' at 31;6.", repo.ApplicationModules.Notepad.ButtonNextInfo, new RecordItemIndex(3));
            repo.ApplicationModules.Notepad.ButtonNext.Click("31;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.Notepad.SetupNotepadPlusPlus.IAgree' at 40;12.", repo.ApplicationModules.Notepad.SetupNotepadPlusPlus.IAgreeInfo, new RecordItemIndex(4));
            repo.ApplicationModules.Notepad.SetupNotepadPlusPlus.IAgree.Click("40;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.Notepad.SetupNotepadPlusPlus.ButtonNext' at 40;12.", repo.ApplicationModules.Notepad.SetupNotepadPlusPlus.ButtonNextInfo, new RecordItemIndex(5));
            repo.ApplicationModules.Notepad.SetupNotepadPlusPlus.ButtonNext.Click("40;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.Notepad.SetupNotepadPlusPlus.ButtonNext' at 40;12.", repo.ApplicationModules.Notepad.SetupNotepadPlusPlus.ButtonNextInfo, new RecordItemIndex(6));
            repo.ApplicationModules.Notepad.SetupNotepadPlusPlus.ButtonNext.Click("40;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.Notepad.ButtonInstall' at 40;12.", repo.ApplicationModules.Notepad.ButtonInstallInfo, new RecordItemIndex(7));
            repo.ApplicationModules.Notepad.ButtonInstall.Click("40;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.Notepad.SetupNotepadPlusPlus.ButtonFinish' at 40;12.", repo.ApplicationModules.Notepad.SetupNotepadPlusPlus.ButtonFinishInfo, new RecordItemIndex(8));
            repo.ApplicationModules.Notepad.SetupNotepadPlusPlus.ButtonFinish.Click("40;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationModules.Notepad.CProgramFilesNotepadPlusPlusChange.Close' at 20;8.", repo.ApplicationModules.Notepad.CProgramFilesNotepadPlusPlusChange.CloseInfo, new RecordItemIndex(9));
            repo.ApplicationModules.Notepad.CProgramFilesNotepadPlusPlusChange.Close.Click("20;8");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
