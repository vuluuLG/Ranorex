/*
 * Created by Ranorex
 * User: thuc.duy.nguyen
 * Date: 5/27/2020
 * Time: 4:34 PM
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

namespace mobileSol.Coding_Modules
{
    /// <summary>
    /// Description of GoToSettingFunctions.
    /// </summary>
    [TestModule("A7D8E859-13AE-4560-86B7-ECB47959DAB5", ModuleType.UserCode, 1)]
    public class GoToSettingFunctions : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GoToSettingFunctions()
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
