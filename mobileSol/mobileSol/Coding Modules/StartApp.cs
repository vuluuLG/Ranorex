/*
 * Created by Ranorex
 * User: thuc.duy.nguyen
 * Date: 6/3/2020
 * Time: 10:07 AM
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

namespace mobileSol.Coding_Modules
{
    /// <summary>
    /// Description of StartApp.
    /// </summary>
    [TestModule("05722412-EFA8-49C5-A662-7EFD84AFA86C", ModuleType.UserCode, 1)]
    public class StartApp : ITestModule
    {
    	public static global::mobileSol.mobileSolRepository repo = global::mobileSol.mobileSolRepository.Instance;
    	static StartApp instance = new StartApp();
    	
    	/// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartApp Instance
        {
            get { return instance; }
        }

        
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartApp()
        {
            modDeviceName = "";
        }
		
		string _modDeviceName = "";
		[TestVariable("a5dc0c85-3bdb-43d5-820c-cbd4a3efbe8f")]
		public string modDeviceName
		{
			get { return _modDeviceName; }
			set { _modDeviceName = value; }
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
            
            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'ranorex.RxBrowser' on device " + Ranorex.Core.Remoting.RemoteServiceLocator.GetCurrentDeviceName() + ".");
            Host.Local.RunMobileApp(Ranorex.Core.Remoting.RemoteServiceLocator.GetCurrentDeviceName(), "org.mozilla.firefox", true);
            
            // Browse to site.
            Report.Log(ReportLevel.Info, "Set value", "Browse to site.\r\nSetting attribute PageUrl to 'http://192.168.171.142/TADashboard' on item 'Browser.Dom'.", repo.Browser.Dom.SelfInfo);
            repo.Browser.Dom.Self.Element.SetAttributeValue("PageUrl", "http://192.168.171.142/TADashboard");
        }
    }
}
