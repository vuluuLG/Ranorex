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
    ///The StartApp recording.
    /// </summary>
    [TestModule("1b57d7b6-d364-4490-8dfc-7904d4291977", ModuleType.Recording, 1)]
    public partial class StartApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::mobileSol.mobileSolRepository repository.
        /// </summary>
        public static global::mobileSol.mobileSolRepository repo = global::mobileSol.mobileSolRepository.Instance;

        static StartApp instance = new StartApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartApp()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartApp Instance
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

            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'ranorex.RxBrowser' on device 'Samsung Galaxy Tab A'.", new RecordItemIndex(0));
            Host.Local.RunMobileApp("Samsung Galaxy Tab A", "ranorex.RxBrowser", true);
            Delay.Milliseconds(3500);
            
            // Browse to site.
            Report.Log(ReportLevel.Info, "Set value", "Browse to site.\r\nSetting attribute PageUrl to 'http://192.168.171.142/TADashboard' on item 'Browser.Dom'.", repo.Browser.Dom.SelfInfo, new RecordItemIndex(1));
            repo.Browser.Dom.Self.Element.SetAttributeValue("PageUrl", "http://192.168.171.142/TADashboard");
            Delay.Milliseconds(10000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
