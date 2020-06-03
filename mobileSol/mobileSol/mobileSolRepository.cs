﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace mobileSol
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the mobileSolRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("481228dd-fc9e-4553-a870-03b9f327e5aa")]
    public partial class mobileSolRepository : RepoGenBaseFolder
    {
        static mobileSolRepository instance = new mobileSolRepository();
        mobileSolRepositoryFolders.BrowserAppFolder _browser;

        /// <summary>
        /// Gets the singleton class instance representing the mobileSolRepository element repository.
        /// </summary>
        [RepositoryFolder("481228dd-fc9e-4553-a870-03b9f327e5aa")]
        public static mobileSolRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public mobileSolRepository() 
            : base("mobileSolRepository", "/", null, 0, false, "481228dd-fc9e-4553-a870-03b9f327e5aa", ".\\RepositoryImages\\mobileSolRepository481228dd.rximgres")
        {
            _browser = new mobileSolRepositoryFolders.BrowserAppFolder(this);
        }

#region Variables

        string _repGSItemName = "";

        /// <summary>
        /// Gets or sets the value of variable repGSItemName.
        /// </summary>
        [TestVariable("3e382d2a-cdf7-4df5-ae3c-5f5d70effc45")]
        public string repGSItemName
        {
            get { return _repGSItemName; }
            set { _repGSItemName = value; }
        }

        string _repMainMenuItem = "";

        /// <summary>
        /// Gets or sets the value of variable repMainMenuItem.
        /// </summary>
        [TestVariable("d10443f0-8177-4ee4-a1ab-5cadc7459319")]
        public string repMainMenuItem
        {
            get { return _repMainMenuItem; }
            set { _repMainMenuItem = value; }
        }

        string _repUsername = "";

        /// <summary>
        /// Gets or sets the value of variable repUsername.
        /// </summary>
        [TestVariable("9070833a-c51c-4996-a05b-acf80582ff3f")]
        public string repUsername
        {
            get { return _repUsername; }
            set { _repUsername = value; }
        }

        string _modDeviceName = "";

        /// <summary>
        /// Gets or sets the value of variable modDeviceName.
        /// </summary>
        [TestVariable("532d27b1-b0c8-42b9-9c51-77e0298b59e5")]
        public string modDeviceName
        {
            get { return _modDeviceName; }
            set { _modDeviceName = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("481228dd-fc9e-4553-a870-03b9f327e5aa")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Browser folder.
        /// </summary>
        [RepositoryFolder("3d413121-290d-4437-9eeb-de457d61dc45")]
        public virtual mobileSolRepositoryFolders.BrowserAppFolder Browser
        {
            get { return _browser; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class mobileSolRepositoryFolders
    {
        /// <summary>
        /// The BrowserAppFolder folder.
        /// </summary>
        [RepositoryFolder("3d413121-290d-4437-9eeb-de457d61dc45")]
        public partial class BrowserAppFolder : RepoGenBaseFolder
        {
            mobileSolRepositoryFolders.LoginPageFolder _loginpage;
            mobileSolRepositoryFolders.DashboardPageFolder _dashboardpage;
            mobileSolRepositoryFolders.DomAppFolder _dom;
            mobileSolRepositoryFolders.BrowserPopupFolder _browserpopup;

            /// <summary>
            /// Creates a new Browser  folder.
            /// </summary>
            public BrowserAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Browser", "/mobileapp[@title='ranorex.RxBrowser']", parentFolder, 10000, null, false, "3d413121-290d-4437-9eeb-de457d61dc45", "")
            {
                _loginpage = new mobileSolRepositoryFolders.LoginPageFolder(this);
                _dashboardpage = new mobileSolRepositoryFolders.DashboardPageFolder(this);
                _dom = new mobileSolRepositoryFolders.DomAppFolder(this);
                _browserpopup = new mobileSolRepositoryFolders.BrowserPopupFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3d413121-290d-4437-9eeb-de457d61dc45")]
            public virtual Ranorex.MobileApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MobileApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3d413121-290d-4437-9eeb-de457d61dc45")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LoginPage folder.
            /// </summary>
            [RepositoryFolder("dac4529d-6e53-49d7-bcad-fd33bbf31227")]
            public virtual mobileSolRepositoryFolders.LoginPageFolder LoginPage
            {
                get { return _loginpage; }
            }

            /// <summary>
            /// The DashboardPage folder.
            /// </summary>
            [RepositoryFolder("bba16f05-3957-42c0-8371-1bcfa250e643")]
            public virtual mobileSolRepositoryFolders.DashboardPageFolder DashboardPage
            {
                get { return _dashboardpage; }
            }

            /// <summary>
            /// The Dom folder.
            /// </summary>
            [RepositoryFolder("11c35c9d-d669-494f-a63f-70257e80752f")]
            public virtual mobileSolRepositoryFolders.DomAppFolder Dom
            {
                get { return _dom; }
            }

            /// <summary>
            /// The BrowserPopup folder.
            /// </summary>
            [RepositoryFolder("9cf4d586-8ba4-4330-b8d1-7fa04f09f8f7")]
            public virtual mobileSolRepositoryFolders.BrowserPopupFolder BrowserPopup
            {
                get { return _browserpopup; }
            }
        }

        /// <summary>
        /// The LoginPageFolder folder.
        /// </summary>
        [RepositoryFolder("dac4529d-6e53-49d7-bcad-fd33bbf31227")]
        public partial class LoginPageFolder : RepoGenBaseFolder
        {
            RepoItemInfo _txtusernameInfo;
            RepoItemInfo _txtpasswordInfo;
            RepoItemInfo _btnloginInfo;
            RepoItemInfo _ddlrepositoryInfo;

            /// <summary>
            /// Creates a new LoginPage  folder.
            /// </summary>
            public LoginPageFolder(RepoGenBaseFolder parentFolder) :
                    base("LoginPage", ".//dom[@path~'login.jsp']", parentFolder, 30000, null, false, "dac4529d-6e53-49d7-bcad-fd33bbf31227", "")
            {
                _txtusernameInfo = new RepoItemInfo(this, "TxtUsername", ".//input[#'username']", 30000, null, "58d476a1-e3f3-45de-a34b-c46ca214e812");
                _txtpasswordInfo = new RepoItemInfo(this, "TxtPassword", ".//input[#'password']", 30000, null, "2513e857-8c81-4d8e-b6fb-ad0ee67b9a92");
                _btnloginInfo = new RepoItemInfo(this, "BtnLogin", ".//div[#'content']/?/div[@class='btn-login']", 30000, null, "f303ea18-5ae5-4b28-9753-454f002dfdbf");
                _ddlrepositoryInfo = new RepoItemInfo(this, "DdlRepository", ".//select[#'repository']", 30000, null, "ac69b930-7609-4c22-9a19-4b507b4447d9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("dac4529d-6e53-49d7-bcad-fd33bbf31227")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("dac4529d-6e53-49d7-bcad-fd33bbf31227")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TxtUsername item.
            /// </summary>
            [RepositoryItem("58d476a1-e3f3-45de-a34b-c46ca214e812")]
            public virtual Ranorex.InputTag TxtUsername
            {
                get
                {
                    return _txtusernameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The TxtUsername item info.
            /// </summary>
            [RepositoryItemInfo("58d476a1-e3f3-45de-a34b-c46ca214e812")]
            public virtual RepoItemInfo TxtUsernameInfo
            {
                get
                {
                    return _txtusernameInfo;
                }
            }

            /// <summary>
            /// The TxtPassword item.
            /// </summary>
            [RepositoryItem("2513e857-8c81-4d8e-b6fb-ad0ee67b9a92")]
            public virtual Ranorex.InputTag TxtPassword
            {
                get
                {
                    return _txtpasswordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The TxtPassword item info.
            /// </summary>
            [RepositoryItemInfo("2513e857-8c81-4d8e-b6fb-ad0ee67b9a92")]
            public virtual RepoItemInfo TxtPasswordInfo
            {
                get
                {
                    return _txtpasswordInfo;
                }
            }

            /// <summary>
            /// The BtnLogin item.
            /// </summary>
            [RepositoryItem("f303ea18-5ae5-4b28-9753-454f002dfdbf")]
            public virtual Ranorex.DivTag BtnLogin
            {
                get
                {
                    return _btnloginInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The BtnLogin item info.
            /// </summary>
            [RepositoryItemInfo("f303ea18-5ae5-4b28-9753-454f002dfdbf")]
            public virtual RepoItemInfo BtnLoginInfo
            {
                get
                {
                    return _btnloginInfo;
                }
            }

            /// <summary>
            /// The DdlRepository item.
            /// </summary>
            [RepositoryItem("ac69b930-7609-4c22-9a19-4b507b4447d9")]
            public virtual Ranorex.SelectTag DdlRepository
            {
                get
                {
                    return _ddlrepositoryInfo.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The DdlRepository item info.
            /// </summary>
            [RepositoryItemInfo("ac69b930-7609-4c22-9a19-4b507b4447d9")]
            public virtual RepoItemInfo DdlRepositoryInfo
            {
                get
                {
                    return _ddlrepositoryInfo;
                }
            }
        }

        /// <summary>
        /// The DashboardPageFolder folder.
        /// </summary>
        [RepositoryFolder("bba16f05-3957-42c0-8371-1bcfa250e643")]
        public partial class DashboardPageFolder : RepoGenBaseFolder
        {
            mobileSolRepositoryFolders.PopupFolder _popup;
            RepoItemInfo _btnglobalsettingInfo;
            RepoItemInfo _btnaddpageInfo;
            RepoItemInfo _btncreateprofileInfo;
            RepoItemInfo _btncreatepanelInfo;
            RepoItemInfo _btnglobalsettingitemInfo;
            RepoItemInfo _lblmainmenuitemInfo;
            RepoItemInfo _lbluserpanelInfo;
            RepoItemInfo _btnlogoutInfo;

            /// <summary>
            /// Creates a new DashboardPage  folder.
            /// </summary>
            public DashboardPageFolder(RepoGenBaseFolder parentFolder) :
                    base("DashboardPage", ".//dom[@path~'/TADashboard/.*.page']", parentFolder, 30000, null, false, "bba16f05-3957-42c0-8371-1bcfa250e643", "")
            {
                _popup = new mobileSolRepositoryFolders.PopupFolder(this);
                _btnglobalsettingInfo = new RepoItemInfo(this, "BtnGlobalSetting", ".//div[#'main-menu']//li[@class='mn-setting']", 30000, null, "612c4bc0-08c3-4f40-b819-1dd17a39ae1a");
                _btnaddpageInfo = new RepoItemInfo(this, "BtnAddPage", ".//div[#'main-menu']//li/a[@innertext='Add Page']", 30000, null, "0907055e-413e-4725-876e-7f366aa6a038");
                _btncreateprofileInfo = new RepoItemInfo(this, "BtnCreateProfile", ".//div[#'main-menu']//li/a[@innertext='Create Profile']", 30000, null, "fb68220b-65a2-4071-8341-868ee2b9d38b");
                _btncreatepanelInfo = new RepoItemInfo(this, "BtnCreatePanel", ".//div[#'main-menu']//li/a[@innertext='Create Panel']", 30000, null, "803ba082-d8de-4b1a-9edd-cd2783343067");
                _btnglobalsettingitemInfo = new RepoItemInfo(this, "BtnGlobalSettingItem", ".//div[#'main-menu']//li/a[@innertext=$repGSItemName]", 30000, null, "45f97d99-b3c5-4451-9548-edb6a1d5be37");
                _lblmainmenuitemInfo = new RepoItemInfo(this, "LblMainMenuItem", ".//div[#'main-menu']//ul//li/a[@innertext=$repMainMenuItem]", 30000, null, "27ead7b6-0298-45b0-9253-2fca024e301e");
                _lbluserpanelInfo = new RepoItemInfo(this, "LblUserPanel", ".//div[#'header']//ul//a[@innertext=$repUsername]", 30000, null, "33b1dc0c-0488-4f82-8ef0-697801e4a81c");
                _btnlogoutInfo = new RepoItemInfo(this, "BtnLogout", ".//div[#'header']//ul[@class='head-menu']//ul//a[@innertext='Logout']", 30000, null, "412e4ab5-b8c4-4d63-8537-efcdd769dadd");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bba16f05-3957-42c0-8371-1bcfa250e643")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("bba16f05-3957-42c0-8371-1bcfa250e643")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The BtnGlobalSetting item.
            /// </summary>
            [RepositoryItem("612c4bc0-08c3-4f40-b819-1dd17a39ae1a")]
            public virtual Ranorex.LiTag BtnGlobalSetting
            {
                get
                {
                    return _btnglobalsettingInfo.CreateAdapter<Ranorex.LiTag>(true);
                }
            }

            /// <summary>
            /// The BtnGlobalSetting item info.
            /// </summary>
            [RepositoryItemInfo("612c4bc0-08c3-4f40-b819-1dd17a39ae1a")]
            public virtual RepoItemInfo BtnGlobalSettingInfo
            {
                get
                {
                    return _btnglobalsettingInfo;
                }
            }

            /// <summary>
            /// The BtnAddPage item.
            /// </summary>
            [RepositoryItem("0907055e-413e-4725-876e-7f366aa6a038")]
            public virtual Ranorex.ATag BtnAddPage
            {
                get
                {
                    return _btnaddpageInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The BtnAddPage item info.
            /// </summary>
            [RepositoryItemInfo("0907055e-413e-4725-876e-7f366aa6a038")]
            public virtual RepoItemInfo BtnAddPageInfo
            {
                get
                {
                    return _btnaddpageInfo;
                }
            }

            /// <summary>
            /// The BtnCreateProfile item.
            /// </summary>
            [RepositoryItem("fb68220b-65a2-4071-8341-868ee2b9d38b")]
            public virtual Ranorex.ATag BtnCreateProfile
            {
                get
                {
                    return _btncreateprofileInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The BtnCreateProfile item info.
            /// </summary>
            [RepositoryItemInfo("fb68220b-65a2-4071-8341-868ee2b9d38b")]
            public virtual RepoItemInfo BtnCreateProfileInfo
            {
                get
                {
                    return _btncreateprofileInfo;
                }
            }

            /// <summary>
            /// The BtnCreatePanel item.
            /// </summary>
            [RepositoryItem("803ba082-d8de-4b1a-9edd-cd2783343067")]
            public virtual Ranorex.ATag BtnCreatePanel
            {
                get
                {
                    return _btncreatepanelInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The BtnCreatePanel item info.
            /// </summary>
            [RepositoryItemInfo("803ba082-d8de-4b1a-9edd-cd2783343067")]
            public virtual RepoItemInfo BtnCreatePanelInfo
            {
                get
                {
                    return _btncreatepanelInfo;
                }
            }

            /// <summary>
            /// The BtnGlobalSettingItem item.
            /// </summary>
            [RepositoryItem("45f97d99-b3c5-4451-9548-edb6a1d5be37")]
            public virtual Ranorex.ATag BtnGlobalSettingItem
            {
                get
                {
                    return _btnglobalsettingitemInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The BtnGlobalSettingItem item info.
            /// </summary>
            [RepositoryItemInfo("45f97d99-b3c5-4451-9548-edb6a1d5be37")]
            public virtual RepoItemInfo BtnGlobalSettingItemInfo
            {
                get
                {
                    return _btnglobalsettingitemInfo;
                }
            }

            /// <summary>
            /// The LblMainMenuItem item.
            /// </summary>
            [RepositoryItem("27ead7b6-0298-45b0-9253-2fca024e301e")]
            public virtual Ranorex.ATag LblMainMenuItem
            {
                get
                {
                    return _lblmainmenuitemInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LblMainMenuItem item info.
            /// </summary>
            [RepositoryItemInfo("27ead7b6-0298-45b0-9253-2fca024e301e")]
            public virtual RepoItemInfo LblMainMenuItemInfo
            {
                get
                {
                    return _lblmainmenuitemInfo;
                }
            }

            /// <summary>
            /// The LblUserPanel item.
            /// </summary>
            [RepositoryItem("33b1dc0c-0488-4f82-8ef0-697801e4a81c")]
            public virtual Ranorex.ATag LblUserPanel
            {
                get
                {
                    return _lbluserpanelInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LblUserPanel item info.
            /// </summary>
            [RepositoryItemInfo("33b1dc0c-0488-4f82-8ef0-697801e4a81c")]
            public virtual RepoItemInfo LblUserPanelInfo
            {
                get
                {
                    return _lbluserpanelInfo;
                }
            }

            /// <summary>
            /// The BtnLogout item.
            /// </summary>
            [RepositoryItem("412e4ab5-b8c4-4d63-8537-efcdd769dadd")]
            public virtual Ranorex.ATag BtnLogout
            {
                get
                {
                    return _btnlogoutInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The BtnLogout item info.
            /// </summary>
            [RepositoryItemInfo("412e4ab5-b8c4-4d63-8537-efcdd769dadd")]
            public virtual RepoItemInfo BtnLogoutInfo
            {
                get
                {
                    return _btnlogoutInfo;
                }
            }

            /// <summary>
            /// The Popup folder.
            /// </summary>
            [RepositoryFolder("9a522199-c9ba-4b64-bfcf-4ff4f1ddce05")]
            public virtual mobileSolRepositoryFolders.PopupFolder Popup
            {
                get { return _popup; }
            }
        }

        /// <summary>
        /// The PopupFolder folder.
        /// </summary>
        [RepositoryFolder("9a522199-c9ba-4b64-bfcf-4ff4f1ddce05")]
        public partial class PopupFolder : RepoGenBaseFolder
        {
            RepoItemInfo _txtpagenameInfo;
            RepoItemInfo _btnokInfo;

            /// <summary>
            /// Creates a new Popup  folder.
            /// </summary>
            public PopupFolder(RepoGenBaseFolder parentFolder) :
                    base("Popup", ".//div[#'div_popup']", parentFolder, 30000, null, false, "9a522199-c9ba-4b64-bfcf-4ff4f1ddce05", "")
            {
                _txtpagenameInfo = new RepoItemInfo(this, "TxtPageName", ".//input[@id='name']", 30000, null, "7809c182-e268-47af-bd31-95c6724abf74");
                _btnokInfo = new RepoItemInfo(this, "BtnOK", ".//input[@id='OK']", 30000, null, "1a14f63d-f13c-48bf-9e5e-c0eff5fc1170");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9a522199-c9ba-4b64-bfcf-4ff4f1ddce05")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9a522199-c9ba-4b64-bfcf-4ff4f1ddce05")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TxtPageName item.
            /// </summary>
            [RepositoryItem("7809c182-e268-47af-bd31-95c6724abf74")]
            public virtual Ranorex.InputTag TxtPageName
            {
                get
                {
                    return _txtpagenameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The TxtPageName item info.
            /// </summary>
            [RepositoryItemInfo("7809c182-e268-47af-bd31-95c6724abf74")]
            public virtual RepoItemInfo TxtPageNameInfo
            {
                get
                {
                    return _txtpagenameInfo;
                }
            }

            /// <summary>
            /// The BtnOK item.
            /// </summary>
            [RepositoryItem("1a14f63d-f13c-48bf-9e5e-c0eff5fc1170")]
            public virtual Ranorex.InputTag BtnOK
            {
                get
                {
                    return _btnokInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The BtnOK item info.
            /// </summary>
            [RepositoryItemInfo("1a14f63d-f13c-48bf-9e5e-c0eff5fc1170")]
            public virtual RepoItemInfo BtnOKInfo
            {
                get
                {
                    return _btnokInfo;
                }
            }
        }

        /// <summary>
        /// The DomAppFolder folder.
        /// </summary>
        [RepositoryFolder("11c35c9d-d669-494f-a63f-70257e80752f")]
        public partial class DomAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new Dom  folder.
            /// </summary>
            public DomAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Dom", ".//dom", parentFolder, 10000, null, false, "11c35c9d-d669-494f-a63f-70257e80752f", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("11c35c9d-d669-494f-a63f-70257e80752f")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("11c35c9d-d669-494f-a63f-70257e80752f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The BrowserPopupFolder folder.
        /// </summary>
        [RepositoryFolder("9cf4d586-8ba4-4330-b8d1-7fa04f09f8f7")]
        public partial class BrowserPopupFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btnokInfo;

            /// <summary>
            /// Creates a new BrowserPopup  folder.
            /// </summary>
            public BrowserPopupFolder(RepoGenBaseFolder parentFolder) :
                    base("BrowserPopup", ".//container[@platformclass~'UIAlertController']", parentFolder, 30000, null, false, "9cf4d586-8ba4-4330-b8d1-7fa04f09f8f7", "")
            {
                _btnokInfo = new RepoItemInfo(this, "BtnOK", ".//*[@accessibilitylabel='OK']", 30000, null, "03530834-552f-43ce-9b95-118216a201f8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9cf4d586-8ba4-4330-b8d1-7fa04f09f8f7")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9cf4d586-8ba4-4330-b8d1-7fa04f09f8f7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The BtnOK item.
            /// </summary>
            [RepositoryItem("03530834-552f-43ce-9b95-118216a201f8")]
            public virtual Ranorex.Unknown BtnOK
            {
                get
                {
                    return _btnokInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The BtnOK item info.
            /// </summary>
            [RepositoryItemInfo("03530834-552f-43ce-9b95-118216a201f8")]
            public virtual RepoItemInfo BtnOKInfo
            {
                get
                {
                    return _btnokInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
