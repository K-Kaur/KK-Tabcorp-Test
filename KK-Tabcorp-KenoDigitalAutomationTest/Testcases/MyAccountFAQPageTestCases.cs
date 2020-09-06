using KK_Tabcorp_KenoDigitalAutomationTest.Pages;
using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Testcases
{
    class MyAccountFAQPageTestCases
    {
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.webdriver = new ChromeDriver();
            PropertiesCollection.webdriver.Navigate().GoToUrl("https://www.keno.com.au/vic/faq");
            PropertiesCollection.webdriver.Manage().Window.Maximize();

            Console.WriteLine("My Account FAQ Page Test Begins");
            Console.WriteLine("Opened Url");
        }

        [Test]
        public void TestCase1()
        {
            //Selecting VIC State

            KenoHomePage page = new KenoHomePage();
            page.SelectState(states.VIC);

            PropertiesCollection.webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Navigating to My Account FAQ page

            FAQPage page1 = new FAQPage();
            page1.myAccountFAQ();

            PropertiesCollection.webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Verifying Forget Password and Forget Account Number links exist

            MyAccountFAQPage page2 = new MyAccountFAQPage();
            page2.forgotPasswordLinkExist();
            page2.forgotAccountNumberLinkExist();
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.webdriver.Close();
            Console.WriteLine("Browser Closed");
            Console.WriteLine("My Account FAQ Page Test Ends");
        }

    }
}
