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
    ///The OpenApp recording.
    /// </summary>
    [TestModule("123028a2-860f-4416-97b3-5bb984146779", ModuleType.Recording, 1)]
    public partial class OpenApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DesktopApp_Automation.DesktopApp_AutomationRepository repository.
        /// </summary>
        public static global::DesktopApp_Automation.DesktopApp_AutomationRepository repo = global::DesktopApp_Automation.DesktopApp_AutomationRepository.Instance;

        static OpenApp instance = new OpenApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenApp()
        {
            varPathSoftware = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Notepad++.lnk";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenApp Instance
        {
            get { return instance; }
        }

#region Variables

        string _varPathSoftware;

        /// <summary>
        /// Gets or sets the value of variable varPathSoftware.
        /// </summary>
        [TestVariable("ff238879-7bc6-4af6-913e-8612507bbea1")]
        public string varPathSoftware
        {
            get { return _varPathSoftware; }
            set { _varPathSoftware = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $varPathSoftware in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(varPathSoftware, "", "", false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'CProgramFilesNotepadPlusPlusChange'.", repo.CProgramFilesNotepadPlusPlusChange.SelfInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.CProgramFilesNotepadPlusPlusChange.SelfInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
