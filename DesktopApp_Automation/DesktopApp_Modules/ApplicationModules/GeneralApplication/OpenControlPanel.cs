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

namespace DesktopApp_Modules.ApplicationModules.GeneralApplication
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenControlPanel recording.
    /// </summary>
    [TestModule("20da548e-0ca7-4fcb-b121-e4913fb1db5a", ModuleType.Recording, 1)]
    public partial class OpenControlPanel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DesktopApp_Modules.DesktopApp_ModulesRepository repository.
        /// </summary>
        public static global::DesktopApp_Modules.DesktopApp_ModulesRepository repo = global::DesktopApp_Modules.DesktopApp_ModulesRepository.Instance;

        static OpenControlPanel instance = new OpenControlPanel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenControlPanel()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenControlPanel Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.TypeHereToSearch' at Center.", repo.Explorer.TypeHereToSearchInfo, new RecordItemIndex(0));
            repo.Explorer.TypeHereToSearch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Control Panel'.", new RecordItemIndex(1));
            Keyboard.Press("Control Panel");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(2));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ControlPanel.Tasklink' at Center.", repo.ControlPanel.TasklinkInfo, new RecordItemIndex(3));
            repo.ControlPanel.Tasklink.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
