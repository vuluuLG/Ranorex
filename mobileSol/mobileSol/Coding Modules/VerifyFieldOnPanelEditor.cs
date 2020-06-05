/*
 * Created by Ranorex
 * User: thuc.duy.nguyen
 * Date: 6/5/2020
 * Time: 3:17 PM
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
    /// Description of VerifyFieldOnPanelEditor.
    /// </summary>
    [TestModule("6EC3E102-67A9-48CC-AB65-33FBE554EF01", ModuleType.UserCode, 1)]
    public class VerifyFieldOnPanelEditor : ITestModule
    {
    	private static mobileSolRepository repo = new mobileSolRepository();
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyFieldOnPanelEditor()
        {
            // Do not delete - a parameterless constructor is required!
        }

        
        string _modPanelType = "";
        [TestVariable("ba497d5d-af84-4c6b-88a5-ba3cd1c043b7")]
        public string modPanelType
        {
        	get { return _modPanelType; }
        	set { _modPanelType = value; }
        }
        
        
        string _modPanelName = "";
        [TestVariable("37c36629-8365-4315-91ed-cc39e5dc415e")]
        public string modPanelName
        {
        	get { return _modPanelName; }
        	set { _modPanelName = value; }
        }
        
        
        string _modStatisticField = "";
        [TestVariable("795457ed-9bfe-40a3-b601-8dca8dd4c9a9")]
        public string modStatisticField
        {
        	get { return _modStatisticField; }
        	set { _modStatisticField = value; }
        }
        
        
        string _modValue = "";
        [TestVariable("8c78e59a-e155-4ba7-88fa-9b316bcd1ec1")]
        public string modValue
        {
        	get { return _modValue; }
        	set { _modValue = value; }
        }
        
        
        string _modFroms = "";
        [TestVariable("40443597-73e1-4549-85cb-7c5108fa2bef")]
        public string modFroms
        {
        	get { return _modFroms; }
        	set { _modFroms = value; }
        }
        
        
        string _modColors = "";
        [TestVariable("b0e9e336-82dd-4418-b9e1-6e2dc0d7b6c7")]
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
            Validate.Exists(mainRepo.InfoSettings.RbPanelType);

            Validate.AttributeEqual(mainRepo.InfoSettings.TxtDisplayName, "Value", modPanelName);
            Report.Log(ReportLevel.Info, "Set value", "Set value " + modStatisticField + " to item 'DdlStatisticField'", mainRepo.DetailSettings.DdlStatisticFieldInfo);
            Validate.AttributeEqual(mainRepo.DetailSettings.DdlStatisticField, "TagValue", modStatisticField);
            
            Report.Log(ReportLevel.Info, "Set value", "Set value " + modValue + " to item 'DdlValue'", mainRepo.DetailSettings.DdlValueInfo);
            Validate.AttributeEqual(mainRepo.DetailSettings.DdlValue, "TagValue", modValue);
            
//            string[] forms = modFroms.Split(',');
//            string[] colors = modColors.Split(',');
//            InputTag txtForm;
//            WebElement btnColor;
//            WebElement btnAdd;
//            
//            for (int i = 2; i <= forms.Length + 1; i++) {
//            	int j = i - 2;
//            	
//				txtForm = mainRepo.Self.FindSingle(".//tr[" + i  + "]//input[@id='criteria']");
//				Report.Log(ReportLevel.Info, "Set value", "Set value " + forms[j] + " to item 'txtForm'");
//	            txtForm.Value = forms[j];
//	            
//	            btnColor = mainRepo.Self.FindSingle(".//tr[" + i  + "]//input[@id='txtColor']");
//	            Report.Log(ReportLevel.Info, "Touch", "Touch to item 'btnColor'");
//	            btnColor.Touch();
//	            
//	            // Assign Hex to repo variable
//	            repo.repHex = Utility.GetHexByColorName(colors[j]);
//	            Report.Log(ReportLevel.Info, "Touch", "Touch to item 'DynamicColor'", repo.Browser.ColorPicker.DynamicColorInfo);
//	            repo.Browser.ColorPicker.DynamicColor.Touch();
//            }
//            
//            mainRepo.BtnOK.Touch();
//            mainRepo.SelfInfo.WaitForNotExists(5000);
        }
    }
}
