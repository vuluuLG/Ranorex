/*
 * Created by Ranorex
 * User: vu.luu
 * Date: 5/30/2020
 * Time: 8:16 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using WinForms = System.Windows.Forms;
using OpenQA.Selenium;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using TADashboard_Modules.Extension;

namespace TADashboard_Modules.Helper_modules
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class ControlExtension
    {
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void SetCheckedState(RepoItemInfo inputtagInfo, string state)
    	{
    		if (!string.IsNullOrEmpty(state)) 
        	{
            	Report.Log(ReportLevel.Info, "Set Checked State", string.Format("Set state '{0}'.", state), inputtagInfo);
            	inputtagInfo.FindAdapter<InputTag>().Element.SetAttributeValue("Checked", state);
        	}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void SelectByText(RepoItemInfo selecttagInfo, string text)
        {
        	if (!string.IsNullOrEmpty(text))
        	{
        		Report.Log(ReportLevel.Info, "Select By Text", string.Format("Select text '{0}'.", text), selecttagInfo);
            	selecttagInfo.FindAdapter<SelectTag>().Element.SetAttributeValue("TagValue", text);
        	}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void InputText(RepoItemInfo inputtagInfo, string text)
    	{
    		if (!string.IsNullOrEmpty(text))
        	{
    			Report.Log(ReportLevel.Info, "Input Text", string.Format("Input text '{0}'.", text), inputtagInfo);
    			var control = inputtagInfo.FindAdapter<InputTag>();
    			if (WebDriverExtension.IsWebDriverEndPoint())
    			{
    				control.PressKeys(Keys.Control + "a");
    			}
    			else
    			{
    				Keyboard.PrepareFocus(control.Element);
            		Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
    			}
            	control.PressKeys(text);
        	}
    	}
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
    }
}
