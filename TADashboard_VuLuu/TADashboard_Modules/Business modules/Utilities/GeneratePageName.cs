/*
 * Created by Ranorex
 * User: vu.luu
 * Date: 6/1/2020
 * Time: 11:52 AM
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
using TADashboard_Modules.Helper_modules;

namespace TADashboard_Modules.Page_modules.Utilities
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("E7B09217-B5E0-4AE9-89AB-17321068C846", ModuleType.UserCode, 1)]
    public class GeneratePageName : ITestModule
    {
    string _modTemplate = "";
    [TestVariable("b4fac839-9b1f-4960-bb95-3c4f9ed16683")]
    public string modTemplate
    {
    	get { return _modTemplate; }
    	set { _modTemplate = value; }
    }
    
    string _modGeneratedName = "";
    [TestVariable("e8f8dd88-b02f-4ded-8d05-7f560e41b4d8")]
    public string modGeneratedName
    {
    	get { return _modGeneratedName; }
    	set { _modGeneratedName = value; }
    }
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GeneratePageName()
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
            
            modGeneratedName = CommonExtension.GenerateDynamicName(modTemplate);
        }
    }
}
