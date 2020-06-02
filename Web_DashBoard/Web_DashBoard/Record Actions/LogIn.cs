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
    ///The LogIn recording.
    /// </summary>
    [TestModule("32b25d90-fcc7-4b82-951e-171f7933c94e", ModuleType.Recording, 1)]
    public partial class LogIn : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Web_DashBoard.Web_DashBoardRepository repository.
        /// </summary>
        public static global::Web_DashBoard.Web_DashBoardRepository repo = global::Web_DashBoard.Web_DashBoardRepository.Instance;

        static LogIn instance = new LogIn();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogIn()
        {
            modUser = "Administrator";
            modPassword = "";
            modRepository = "SampleRepository";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LogIn Instance
        {
            get { return instance; }
        }

#region Variables

        string _modUser;

        /// <summary>
        /// Gets or sets the value of variable modUser.
        /// </summary>
        [TestVariable("a71012bb-098e-4af1-9403-57d63f300d42")]
        public string modUser
        {
            get { return _modUser; }
            set { _modUser = value; }
        }

        string _modPassword;

        /// <summary>
        /// Gets or sets the value of variable modPassword.
        /// </summary>
        [TestVariable("f52fbe2a-0ac7-4107-ab78-c181d1010688")]
        public string modPassword
        {
            get { return _modPassword; }
            set { _modPassword = value; }
        }

        string _modRepository;

        /// <summary>
        /// Gets or sets the value of variable modRepository.
        /// </summary>
        [TestVariable("64e39241-b5be-44c2-bfb6-823dbec266e4")]
        public string modRepository
        {
            get { return _modRepository; }
            set { _modRepository = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$modRepository' on item 'Dashboard.LogIn.cbbRepository'.", repo.Dashboard.LogIn.cbbRepositoryInfo, new RecordItemIndex(0));
            repo.Dashboard.LogIn.cbbRepository.Element.SetAttributeValue("TagValue", modRepository);
            Delay.Milliseconds(20);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dashboard.LogIn.txtUsername' at Center.", repo.Dashboard.LogIn.txtUsernameInfo, new RecordItemIndex(1));
            //repo.Dashboard.LogIn.txtUsername.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$modUser' on item 'Dashboard.LogIn.txtUsername'.", repo.Dashboard.LogIn.txtUsernameInfo, new RecordItemIndex(2));
            repo.Dashboard.LogIn.txtUsername.Element.SetAttributeValue("Value", modUser);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dashboard.LogIn.txtPassword' at Center.", repo.Dashboard.LogIn.txtPasswordInfo, new RecordItemIndex(3));
            //repo.Dashboard.LogIn.txtPassword.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$modPassword' on item 'Dashboard.LogIn.txtPassword'.", repo.Dashboard.LogIn.txtPasswordInfo, new RecordItemIndex(4));
            repo.Dashboard.LogIn.txtPassword.Element.SetAttributeValue("Value", modPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dashboard.LogIn.btnLogin' at Center.", repo.Dashboard.LogIn.btnLoginInfo, new RecordItemIndex(5));
            repo.Dashboard.LogIn.btnLogin.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
