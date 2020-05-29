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

namespace mobileSol.Recording_Modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LogOut recording.
    /// </summary>
    [TestModule("2e7a9cf5-f61a-4dc2-af9e-2f87a1bc74ff", ModuleType.Recording, 1)]
    public partial class LogOut : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::mobileSol.mobileSolRepository repository.
        /// </summary>
        public static global::mobileSol.mobileSolRepository repo = global::mobileSol.mobileSolRepository.Instance;

        static LogOut instance = new LogOut();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogOut()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LogOut Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varUsername.
        /// </summary>
        [TestVariable("9070833a-c51c-4996-a05b-acf80582ff3f")]
        public string varUsername
        {
            get { return repo.varUsername; }
            set { repo.varUsername = value; }
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'Browser.DashboardPage.LblUserPanel' at Center", repo.Browser.DashboardPage.LblUserPanelInfo, new RecordItemIndex(0));
            repo.Browser.DashboardPage.LblUserPanel.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'Browser.DashboardPage.BtnLogout' at Center", repo.Browser.DashboardPage.BtnLogoutInfo, new RecordItemIndex(1));
            repo.Browser.DashboardPage.BtnLogout.Touch();
            Delay.Milliseconds(300);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
