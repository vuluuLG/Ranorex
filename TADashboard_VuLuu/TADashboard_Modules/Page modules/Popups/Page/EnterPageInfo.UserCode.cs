﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TADashboard_Modules.Page_modules.Popups.Page
{
    public partial class EnterPageInfo
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Key_sequence_TxtPageName(RepoItemInfo inputtagInfo)
        {
        	if (!string.IsNullOrEmpty(varPageName))
        	{
        		Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPageName' with focus on 'inputtagInfo'.", inputtagInfo);
            	inputtagInfo.FindAdapter<InputTag>().PressKeys(varPageName);
        	}
        }

        public void Set_value_CbxNumberOfColumns(RepoItemInfo selecttagInfo)
        {
        	if (!string.IsNullOrEmpty(varColNumber))
        	{
        		Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$varColNumber' on item 'selecttagInfo'.", selecttagInfo);
            	selecttagInfo.FindAdapter<SelectTag>().Element.SetAttributeValue("TagValue", varColNumber);
        	}
        }

        public void Set_value_CbxParentPage(RepoItemInfo selecttagInfo)
        {
        	if (!string.IsNullOrEmpty(varParentPage))
        	{
        		Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$varParentPage' on item 'selecttagInfo'.", selecttagInfo);
            	selecttagInfo.FindAdapter<SelectTag>().Element.SetAttributeValue("TagValue", varParentPage);
        	}
        }

        public void Set_value_CbxDisplayAfter(RepoItemInfo selecttagInfo)
        {
        	if (!string.IsNullOrEmpty(varDisplayAfter)) 
        	{
            	Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$varDisplayAfter' on item 'selecttagInfo'.", selecttagInfo);
            	selecttagInfo.FindAdapter<SelectTag>().Element.SetAttributeValue("TagValue", varDisplayAfter);
        	}
        }
        
        public void Set_value_ChxIsPublic(RepoItemInfo inputtagInfo)
        {
        	if (!string.IsNullOrEmpty(varIsPublic)) 
        	{
            	Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to '$varIsPublic' on item 'inputtagInfo'.", inputtagInfo);
            	inputtagInfo.FindAdapter<InputTag>().Element.SetAttributeValue("Checked", varIsPublic);
        	}
        }
        	
    }
}
