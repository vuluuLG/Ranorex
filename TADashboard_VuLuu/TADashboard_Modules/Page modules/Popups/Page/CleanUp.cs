﻿/*
 * Created by Ranorex
 * User: vu.luu
 * Date: 5/30/2020
 * Time: 12:21 PM
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

namespace TADashboard_Modules.Page_modules.Popups.Page
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("37146515-AD3E-4997-A5D2-2825BE8BC15D", ModuleType.UserCode, 1)]
    public class CleanUp : ITestModule
    {
    	/// <summary>
        /// Holds an instance of the global::TADashboard_Modules.TADashboard_Repository repository.
        /// </summary>
        public static global::TADashboard_Modules.TADashboard_Repository repo = global::TADashboard_Modules.TADashboard_Repository.Instance;
	    
	    [TestVariable("991de919-ecac-4ecb-81d1-e99ce47ba075")]
	    public string repoTabName
	    {
	    	get { return repo.repoTabName; }
	    	set { repo.repoTabName = value; }
	    }
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CleanUp()
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
            
            if (repo.TADashboard.Pages.BasePage.MainMenu.LnkPageTabInfo.Exists())
            {
            	// Select tab
            	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TADashboard.Pages.BasePage.MainMenu.LnkPageTab' at Center.", repo.TADashboard.Pages.BasePage.MainMenu.LnkPageTabInfo);
            	repo.TADashboard.Pages.BasePage.MainMenu.LnkPageTab.Click();
            	
            	// Wait for tab selected
            	try {
                	Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Class' to equal the specified value 'active'. Associated repository item: 'TADashboard.Pages.BasePage.MainMenu.LnkPageTab'", repo.TADashboard.Pages.BasePage.MainMenu.LnkPageTabInfo);
                	repo.TADashboard.Pages.BasePage.MainMenu.LnkPageTabInfo.WaitForAttributeEqual(5000, "Class", "active");
            	} catch(Exception) { }
            	
            	// Hover on Setting icon
	            Report.Log(ReportLevel.Info, "Mouse", "Hover on Setting icon\r\nMouse Left Move item 'TADashboard.Pages.BasePage.MainMenu.LnkSetting' at Center.", repo.TADashboard.Pages.BasePage.MainMenu.LnkSettingInfo);
	            repo.TADashboard.Pages.BasePage.MainMenu.LnkSetting.MoveTo();
	            
	            // Select setting
	            Report.Log(ReportLevel.Info, "Mouse", "Select setting\r\nMouse Left Click item 'TADashboard.Pages.BasePage.MainMenu.GlobalSetting.LnkSetting' at Center.", repo.TADashboard.Pages.BasePage.MainMenu.GlobalSetting.LnkSettingInfo);
	            repo.repoSettingName = "Delete";
	            repo.TADashboard.Pages.BasePage.MainMenu.GlobalSetting.LnkSetting.Click();
	            
	            // Select OK on confirm dialog
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Browser.Dialogs.ButtonOK' at Center.", repo.Browser.Dialogs.ButtonOKInfo);
            	repo.Browser.Dialogs.ButtonOK.Click();
            }
        }
    }
}
