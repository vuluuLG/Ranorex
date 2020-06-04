/*
 * Created by Ranorex
 * User: thuc.duy.nguyen
 * Date: 6/3/2020
 * Time: 3:58 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections;
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
    /// Description of SetFieldOnPagePanel.
    /// </summary>
    [TestModule("40DF2330-379B-4E47-B6D2-D35383935E96", ModuleType.UserCode, 1)]
    public class SetFieldOnPanelEditor : ITestModule
    {
    	private static mobileSolRepository repo = new mobileSolRepository();
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetFieldOnPanelEditor()
        {
            // Do not delete - a parameterless constructor is required!
        }

        
        string _modPanelType = "";
        [TestVariable("354cdc55-2853-4250-afd9-e225e0262b21")]
        public string modPanelType
        {
        	get { return _modPanelType; }
        	set { _modPanelType = value; }
        }
        
        
        string _modPanelName = "";
        [TestVariable("a7e4a9c2-dab2-4d12-8297-c9f429c19cd6")]
        public string modPanelName
        {
        	get { return _modPanelName; }
        	set { _modPanelName = value; }
        }
        
        
        string _modStatisticField = "";
        [TestVariable("c4bc7f70-b1dc-4a07-85b8-d6e0c3c0a84e")]
        public string modStatisticField
        {
        	get { return _modStatisticField; }
        	set { _modStatisticField = value; }
        }
        
        
        string _modValue = "";
        [TestVariable("6d35f351-a8f1-4ebb-b614-fc4dbcab2033")]
        public string modValue
        {
        	get { return _modValue; }
        	set { _modValue = value; }
        }
        
        
        string _modForms;
        [TestVariable("79a3f2bb-3e5b-4259-a75e-a58c51c19b39")]
        public string modForms
        {
        	get { return _modForms; }
        	set { _modForms = value; }
        }
        
        
        string _modColors = "";
        [TestVariable("905f7661-52ae-44c4-abdc-9322f721d1cb")]
        public string modColors
        {
        	get { return _modColors; }
        	set { _modColors = value; }
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
            
            var mainRepo = repo.Browser.PanelsPage.AddNewPanel;
            
            repo.repPanelType = modPanelType;
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RbPanelType' at Center", mainRepo.InfoSettings.RbPanelTypeInfo);
            mainRepo.InfoSettings.RbPanelType.Touch();
            
            mainRepo.InfoSettings.TxtDisplayName.Value = modPanelName;
            Report.Log(ReportLevel.Info, "Set value", "Set value " + modStatisticField + " to item 'DdlStatisticField'", mainRepo.DetailSettings.DdlStatisticFieldInfo);
            mainRepo.DetailSettings.DdlStatisticField.TagValue = modStatisticField;
            
            Report.Log(ReportLevel.Info, "Set value", "Set value " + modValue + " to item 'DdlValue'", mainRepo.DetailSettings.DdlValueInfo);
            mainRepo.DetailSettings.DdlValue.TagValue = modValue;
            
            string[] forms = modForms.Split(',');
            string[] colors = modColors.Split(',');
            InputTag txtForm;
            WebElement btnColor;
            WebElement btnAdd;
            
            for (int i = 2; i <= forms.Length + 1; i++) {
            	int j = i - 2;
            	Delay.Seconds(1);
	            
            	if (!Equals(i, 2)) {
	            	btnAdd = mainRepo.Self.FindSingle(".//tr[" + (i - 1) + "]//img[@id='btnAdd'");
	            	Report.Log(ReportLevel.Info, "Touch", "Touch to item 'btnAdd'");
            		btnAdd.Touch();
            	}
            	
				txtForm = mainRepo.Self.FindSingle(".//tr[" + i  + "]//input[@id='criteria']");
				Report.Log(ReportLevel.Info, "Set value", "Set value " + forms[j] + " to item 'txtForm'");
	            txtForm.Value = forms[j];
	            
	            btnColor = mainRepo.Self.FindSingle(".//tr[" + i  + "]//input[@id='txtColor']");
	            Report.Log(ReportLevel.Info, "Touch", "Touch to item 'btnColor'");
	            btnColor.Touch();
	            
	            // Assign Hex to repo variable
	            repo.repHex = Utility.GetHexByColorName(colors[j]);
	            Report.Log(ReportLevel.Info, "Touch", "Touch to item 'DynamicColor'", repo.Browser.ColorPicker.DynamicColorInfo);
	            repo.Browser.ColorPicker.DynamicColor.Touch();
            }
            
            mainRepo.BtnOK.Touch();
        }
    }
}
