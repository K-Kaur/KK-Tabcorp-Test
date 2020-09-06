using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Pages
{
    class FAQPage
    {
        //creating a page object for FAQ Page
        public FAQPage()
        {
            PageFactory.InitElements(PropertiesCollection.webdriver, this);
        }

        //finding elements on FAQ Page

        //My account link
        [FindsBy(How = How.CssSelector, Using = "[data-id='faq-category-1']")]
        public IWebElement myAccountLink { get; set; }

        //Clicking my account link
        public FAQPage myAccountFAQ()
        {
            myAccountLink.Click();
            Console.WriteLine("My Account Link clicked");

            return new FAQPage();
        }
    }
}
