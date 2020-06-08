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

namespace Web_DashBoard.Record_Actions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenBrowser recording.
    /// </summary>
    [TestModule("abdff23a-ebdb-460e-a1e2-ad870356a5e0", ModuleType.Recording, 1)]
    public partial class OpenBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Web_DashBoard.Web_DashBoardRepository repository.
        /// </summary>
        public static global::Web_DashBoard.Web_DashBoardRepository repo = global::Web_DashBoard.Web_DashBoardRepository.Instance;

        static OpenBrowser instance = new OpenBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser()
        {
            modBrowser = "Chrome";
            mdDomain = "192.168.1.19";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenBrowser Instance
        {
            get { return instance; }
        }

#region Variables

        string _modBrowser;

        /// <summary>
        /// Gets or sets the value of variable modBrowser.
        /// </summary>
        [TestVariable("3cb61d55-6e68-4335-b3a1-4b71b421fed2")]
        public string modBrowser
        {
            get { return _modBrowser; }
            set { _modBrowser = value; }
        }

        string _mdDomain;

        /// <summary>
        /// Gets or sets the value of variable mdDomain.
        /// </summary>
        [TestVariable("dd935287-e460-4408-b802-3bb74b33b4fb")]
        public string mdDomain
        {
            get { return _mdDomain; }
            set { _mdDomain = value; }
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

            OpenBrowser_OpenDashboard(mdDomain, modBrowser);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
