/*
 * Created by Ranorex
 * User: thuc.duy.nguyen
 * Date: 5/29/2020
 * Time: 4:42 PM
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
    /// Description of ModifyPageNameUpdate.
    /// </summary>
    [TestModule("24E437C0-45E6-4D5B-91AA-D845E139CC08", ModuleType.UserCode, 1)]
    public class ModifyPageNameUpdate : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ModifyPageNameUpdate()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        
        string _input = "";
        [TestVariable("57f24b32-960d-4822-a708-972f23586c26")]
        public string input
        {
        	get { return _input; }
        	set { _input = value; }
        }
        
        
        string _output = "";
        [TestVariable("a57fe166-80bf-45d4-8080-a207c12485f5")]
        public string output
        {
        	get { return _output; }
        	set { _output = value; }
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
            
            output = input.ToString() + "Update";
        }
    }
}
