using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Pages
{
    class MyAccountFAQPage
    {
        //creating a page object for My Account FAQ Page
        public MyAccountFAQPage()
        {
            PageFactory.InitElements(PropertiesCollection.webdriver, this);
        }

        //finding elements on My Account FAQ Page

        //I Forgot my password link
        [FindsBy(How = How.Id, Using = "i-forgot-my-password")]
        public IWebElement forgotPasswordLink { get; set; }

        //I Forgot my account number link
        [FindsBy(How = How.Id, Using = "i-forgot-my-account-number")]
        public IWebElement forgotAccountNumberLink { get; set; }

        //Verifying forgot Password Link exist on the Page
        public bool forgotPasswordLinkExist() => forgotPasswordLink.Displayed;

        //Verifying forgot Account Number Link exist on the Page
        public bool forgotAccountNumberLinkExist() => forgotAccountNumberLink.Displayed;
    }
}
