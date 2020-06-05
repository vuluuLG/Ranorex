/*
 * Created by Ranorex
 * User: vu.luu
 * Date: 5/29/2020
 * Time: 2:17 PM
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
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TADashboard_Modules.Helper_modules
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class WaitExtension
    {
    	public const int maxTime = 60;
    	public const int longTime = 30;
    	public const int mediumTime = 15;
    	public const int sortTime = 3;
    	public const int minTime = 1;
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void WaitForPageLoad(RepoItemInfo page, int timeout = maxTime)
    	{
    		Report.Log(ReportLevel.Info, "Wait", "Wait for document loaded.", page);
    		page.FindAdapter<WebDocument>().WaitForDocumentLoaded(timeout);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void WaitForPageLoad(RepoItemInfo page, RepoItemInfo requiredItem, int timeout = maxTime)
    	{
    		WaitForPageLoad(page, timeout);
    		Report.Log(ReportLevel.Info, "Wait", "Wait for required item loaded.", page);
    		requiredItem.WaitForExists(timeout);
    	}
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
    }
}
