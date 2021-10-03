using System.Collections;
using System.Collections.Generic;
using DevionGames.UIWidgets;
using UnityEngine;
using UnityEngine.Assertions;

namespace DevionGames.LoginSystem.Configuration
{
    public class UI : Settings
    {
        public override string Name
        {
            get
            {
                return "UI";
            }
        }

        public override int Order { get => 1; }

        [Header("UI References:")]
        [InspectorLabel("Login Window", "Name of the login window.")]
        public string loginWindowName = "Login";
        [InspectorLabel("Registration Window", "Name of the registration window.")]
        public string registrationWindowName = "Registration";
        [InspectorLabel("Recover Password Window", "Name of the recover password window.")]
        public string recoverPasswordWindowName = "Recover Password";
        [InspectorLabel("Dialog Box", "Name of the dialog box widget.")]
        public string dialogBoxName = "Dialog Box";
        [InspectorLabel("Tooltip", "Name of the tooltip widget.")]
        public string tooltipName = "Tooltip";


        private LoginWindow m_LoginWindow;
        public LoginWindow loginWindow
        {
            get
            {
                if (this.m_LoginWindow == null)
                {
                    this.m_LoginWindow = WidgetUtility.Find<LoginWindow>(this.loginWindowName);
                }
                Assert.IsNotNull(this.m_LoginWindow, "Login Window with name " + this.loginWindowName + " is not present in scene.");
                return this.m_LoginWindow;
            }
        }

       
    }
}