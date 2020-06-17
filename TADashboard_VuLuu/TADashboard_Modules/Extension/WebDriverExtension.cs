/*
 * Created by Ranorex
 * User: vu.luu
 * Date: 6/17/2020
 * Time: 2:47 PM
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
using OpenQA.Selenium.Support.UI;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TADashboard_Modules.Extension
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class WebDriverExtension
    {
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static bool IsWebDriverEndPoint()
    	{
    		if (Host.Current.TryGetAsWebDriverEndpoint() != null)
    		{
    			return true;
    		}
    		return false;
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static IWebDriver GetCurrentWebDriver()
    	{
    		if (IsWebDriverEndPoint())
    		{
    			var webDriverEndPoint = Host.Current.TryGetAsWebDriverEndpoint();
    			foreach (var driver in webDriverEndPoint.WebDrivers) {
    				return driver;
    			}
    		}
    		return null;
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void WaitForAlert(Duration timeout)
    	{
    		var wait = new WebDriverWait(GetCurrentWebDriver(), timeout.TimeSpan);
    		wait.Until(ExpectedConditions.AlertIsPresent());
    	}
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
    }
}
