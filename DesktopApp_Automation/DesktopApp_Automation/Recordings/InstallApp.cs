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

namespace DesktopApp_Automation.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InstallApp recording.
    /// </summary>
    [TestModule("34a2672d-15b3-4cca-b381-442a2d20103c", ModuleType.Recording, 1)]
    public partial class InstallApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DesktopApp_Automation.DesktopApp_AutomationRepository repository.
        /// </summary>
        public static global::DesktopApp_Automation.DesktopApp_AutomationRepository repo = global::DesktopApp_Automation.DesktopApp_AutomationRepository.Instance;

        static InstallApp instance = new InstallApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InstallApp()
        {
            varVersion = "7.8.6";
            varStartAut = "Downloads\\npp.7.8.6.Installer.x64.exe";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InstallApp Instance
        {
            get { return instance; }
        }

#region Variables

        string _varVersion;

        /// <summary>
        /// Gets or sets the value of variable varVersion.
        /// </summary>
        [TestVariable("d621bdb1-a622-4131-9ece-108d110150cc")]
        public string varVersion
        {
            get { return _varVersion; }
            set { _varVersion = value; }
        }

        string _varStartAut;

        /// <summary>
        /// Gets or sets the value of variable varStartAut.
        /// </summary>
        [TestVariable("3ddb315b-cfb7-4296-b25f-b0b854fdc8cf")]
        public string varStartAut
        {
            get { return _varStartAut; }
            set { _varStartAut = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $varStartAut in normal mode. Return value bound to $varStartAut.", new RecordItemIndex(0));
            varStartAut = ValueConverter.ToString(Host.Local.RunApplication(varStartAut, "", "", false));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InstallerLanguage.ButtonOK' at 28;10.", repo.InstallerLanguage.ButtonOKInfo, new RecordItemIndex(1));
            repo.InstallerLanguage.ButtonOK.Click("28;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotepadPlusPlusV786Setup.ButtonNext' at 20;9.", repo.NotepadPlusPlusV786Setup.ButtonNextInfo, new RecordItemIndex(2));
            repo.NotepadPlusPlusV786Setup.ButtonNext.Click("20;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotepadPlusPlusV786Setup.IAgree' at 20;9.", repo.NotepadPlusPlusV786Setup.IAgreeInfo, new RecordItemIndex(3));
            repo.NotepadPlusPlusV786Setup.IAgree.Click("20;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotepadPlusPlusV786Setup.ButtonNext' at 17;9.", repo.NotepadPlusPlusV786Setup.ButtonNextInfo, new RecordItemIndex(4));
            repo.NotepadPlusPlusV786Setup.ButtonNext.Click("17;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotepadPlusPlusV786Setup.ButtonNext' at 17;9.", repo.NotepadPlusPlusV786Setup.ButtonNextInfo, new RecordItemIndex(5));
            repo.NotepadPlusPlusV786Setup.ButtonNext.Click("17;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotepadPlusPlusV786Setup.ButtonInstall' at 17;9.", repo.NotepadPlusPlusV786Setup.ButtonInstallInfo, new RecordItemIndex(6));
            repo.NotepadPlusPlusV786Setup.ButtonInstall.Click("17;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Title>$varVersion) on item 'NotepadPlusPlusV786Setup'.", repo.NotepadPlusPlusV786Setup.SelfInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.NotepadPlusPlusV786Setup.SelfInfo, "Title", varVersion);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotepadPlusPlusV786Setup.ButtonFinish' at 31;10.", repo.NotepadPlusPlusV786Setup.ButtonFinishInfo, new RecordItemIndex(8));
            repo.NotepadPlusPlusV786Setup.ButtonFinish.Click("31;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CProgramFilesNotepadPlusPlusChange.Close' at 20;16.", repo.CProgramFilesNotepadPlusPlusChange.CloseInfo, new RecordItemIndex(9));
            repo.CProgramFilesNotepadPlusPlusChange.Close.Click("20;16");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
