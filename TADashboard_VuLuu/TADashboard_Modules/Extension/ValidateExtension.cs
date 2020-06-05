/*
 * Created by Ranorex
 * User: vu.luu
 * Date: 6/5/2020
 * Time: 3:14 PM
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

namespace TADashboard_Modules.Extension
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class ValidateExtension
    {
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void ValidateExists(RepoItemInfo repoItemInfo, Duration searchTimeout)
    	{
    		Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'repoItemInfo'.", repoItemInfo);
            Validate.Exists(repoItemInfo.AbsolutePath, searchTimeout);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void ValidateNotExists(RepoItemInfo repoItemInfo, Duration searchTimeout)
    	{
    		Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'repoItemInfo'.", repoItemInfo);
            Validate.NotExists(repoItemInfo.AbsolutePath, searchTimeout);
    	}
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
    }
}
