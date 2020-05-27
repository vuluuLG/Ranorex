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
    ///The Login recording.
    /// </summary>
    [TestModule("80c2ffe4-1e67-44b5-9b5c-f20cd908e272", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::mobileSol.mobileSolRepository repository.
        /// </summary>
        public static global::mobileSol.mobileSolRepository repo = global::mobileSol.mobileSolRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            varRepository = "SampleRepository";
            varUsername = "administrator";
            varPassword = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _varRepository;

        /// <summary>
        /// Gets or sets the value of variable varRepository.
        /// </summary>
        [TestVariable("f19cc64b-e78e-4d7d-8ae1-f7db2140002d")]
        public string varRepository
        {
            get { return _varRepository; }
            set { _varRepository = value; }
        }

        string _varUsername;

        /// <summary>
        /// Gets or sets the value of variable varUsername.
        /// </summary>
        [TestVariable("6ad1199e-33da-4ce5-80fc-92782850c33d")]
        public string varUsername
        {
            get { return _varUsername; }
            set { _varUsername = value; }
        }

        string _varPassword;

        /// <summary>
        /// Gets or sets the value of variable varPassword.
        /// </summary>
        [TestVariable("5f637e61-89db-413d-9a9d-7ca7628bffb9")]
        public string varPassword
        {
            get { return _varPassword; }
            set { _varPassword = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$varRepository' on item 'Browser.LoginPage.DdlRepository'.", repo.Browser.LoginPage.DdlRepositoryInfo, new RecordItemIndex(0));
            repo.Browser.LoginPage.DdlRepository.Element.SetAttributeValue("TagValue", varRepository);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$varUsername' on item 'Browser.LoginPage.TxtUsername'.", repo.Browser.LoginPage.TxtUsernameInfo, new RecordItemIndex(1));
            repo.Browser.LoginPage.TxtUsername.Element.SetAttributeValue("TagValue", varUsername);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$varPassword' on item 'Browser.LoginPage.TxtPassword'.", repo.Browser.LoginPage.TxtPasswordInfo, new RecordItemIndex(2));
            repo.Browser.LoginPage.TxtPassword.Element.SetAttributeValue("TagValue", varPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'Browser.LoginPage.BtnLogin' at Center", repo.Browser.LoginPage.BtnLoginInfo, new RecordItemIndex(3));
            repo.Browser.LoginPage.BtnLogin.Touch();
            Delay.Milliseconds(300);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
