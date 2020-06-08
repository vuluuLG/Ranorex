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

namespace Web_DashBoard.Record_Actions.Panel
{
    public partial class EnterIndicatorSetting
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void AddCriteria(string modPanelFroms, string modPanelColors)
        {           
        	Report.Log(ReportLevel.Info,"Add Criterias: " + modPanelFroms);
        	if (modPanelFroms!="") {
        		string[] arrFroms = modPanelFroms.Split(',');
        		string[] arrColors = modPanelColors.Split(',');
        		
        		for (int i = 0; i < arrFroms.Length; i++) {
        			string varFrom = arrFroms[i];
        			string varColor = arrColors[i];
        			int varRow = i+2;
        			if (i>0) {
        				int varButtonRow = i+1;        					
						ImgTag btnAdd = "//table[@id='tblThreshold']//tr["+ varButtonRow +"]//img[@id='btnAdd']";        					
						Report.Log(ReportLevel.Info,"Add one more  criteria.");
        				btnAdd.Click();
        			}
        			InputTag txtFrom = "//table[@id='tblThreshold']//tr["+ varRow +"]//input[@id='criteria']";
        			InputTag txtColor = "//table[@id='tblThreshold']//tr["+ varRow +"]//input[@id='txtColor']";        				        				
        				
        			txtFrom.Element.SetAttributeValue("Value",varFrom);
        			txtColor.Click();
        			repo.Dashboard.ColorPickerTable.SelfInfo.WaitForExists(5000);
        				
        			TdTag tdPickedColor = "//table[@id='colorPickerTable']//td[@title~'"+ varColor +"']";
        			tdPickedColor.Click();        			
        		}
        	}      	
        }

        public void SetStatisticField(RepoItemInfo selecttagInfo)
        {
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$modPanelStatisticfield' on item 'selecttagInfo'.", selecttagInfo);
            selecttagInfo.FindAdapter<SelectTag>().Element.SetAttributeValue("TagValue", modPanelStatisticfield);
        }

        public void Set_value_cbbStatisticField(RepoItemInfo selecttagInfo)
        {
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$modPanelStatisticfield' on item 'selecttagInfo'.", selecttagInfo);
            selecttagInfo.FindAdapter<SelectTag>().Element.SetAttributeValue("TagValue", modPanelStatisticfield);
        }
    }
}
