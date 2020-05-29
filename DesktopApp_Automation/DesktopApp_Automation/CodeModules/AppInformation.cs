﻿/*
 * Created by Ranorex
 * User: Administrator
 * Date: 5/29/2020
 * Time: 10:14 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace DesktopApp_Automation.CodeModules
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("8CE048C9-5B2F-452B-9510-D5463AC28B4F", ModuleType.UserCode, 1)]
    public class AppInformation : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AppInformation()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
