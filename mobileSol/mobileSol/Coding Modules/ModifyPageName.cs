/*
 * Created by Ranorex
 * User: thuc.duy.nguyen
 * Date: 5/29/2020
 * Time: 1:51 PM
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

using mobileSol.Common;

namespace mobileSol.Coding_Modules
{
    /// <summary>
    /// Description of ModifyPage.
    /// </summary>
    [TestModule("122ADCE5-ADB5-4215-82C4-0DAE0B749633", ModuleType.UserCode, 1)]
    public class ModifyPageName : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ModifyPageName()
        {
            // Do not delete - a parameterless constructor is required!
            pageName = "";
            pageNameReturn = "";
        }
        
        public static mobileSolRepository repo = new mobileSolRepository();

        
        string _pageName = "";
        [TestVariable("09e49ae6-d7d9-4379-bb25-7a83e47f6f07")]
        public string pageName
        {
        	get { return _pageName; }
        	set { _pageName = value; }
        }
        
        string _pageNameReturn = "";
        [TestVariable("4d4dda97-2813-4227-ac99-c3232dff2415")]
        public string pageNameReturn
        {
        	get { return _pageNameReturn; }
        	set { _pageNameReturn = value; }
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
            
            pageNameReturn = pageName.ToString() + Utility.GetCurrentDate("yyyyddMM");
        }
    }
}
