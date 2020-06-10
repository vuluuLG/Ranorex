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
    ///The ValidateAppOpened recording.
    /// </summary>
    [TestModule("44cc08ed-ee9e-4d58-a76d-750ceb07306b", ModuleType.Recording, 1)]
    public partial class ValidateAppOpened : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DesktopApp_Modules.DesktopApp_ModulesRepository repository.
        /// </summary>
        public static global::DesktopApp_Modules.DesktopApp_ModulesRepository repo = global::DesktopApp_Modules.DesktopApp_ModulesRepository.Instance;

        static ValidateAppOpened instance = new ValidateAppOpened();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateAppOpened()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateAppOpened Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable repoProcessNameScreenApp.
        /// </summary>
        [TestVariable("f932be9f-bdab-4342-8312-f6361a48bc95")]
        public string repoProcessNameScreenApp
        {
            get { return repo.repoProcessNameScreenApp; }
            set { repo.repoProcessNameScreenApp = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Application.ScreenApp'.", repo.Application.ScreenApp.SelfInfo, new RecordItemIndex(0));
            Validate.Exists(repo.Application.ScreenApp.SelfInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
