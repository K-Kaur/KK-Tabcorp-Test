using KK_Tabcorp_KenoDigitalAutomationTest.Pages;
using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Testcases
{
    class CheckResultsPageTestCases
    {
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.webdriver = new ChromeDriver();
            PropertiesCollection.webdriver.Navigate().GoToUrl("https://www.keno.com.au/check-results/");
            PropertiesCollection.webdriver.Manage().Window.Maximize();

            Console.WriteLine("Check Results Page Test Begins");
            Console.WriteLine("Opened Url");
        }

        [Test]
        public void TestCase1()
        {
            //Selecting VIC state

            KenoHomePage page = new KenoHomePage();
            page.SelectState(states.VIC);

            PropertiesCollection.webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Entering details on Check Results page and clicking Check Results button

            CheckResultsPage page1 = new CheckResultsPage();
            page1.enterDetailsToCheckResults("04-09-2020", "200", "2");
        }
        
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.webdriver.Close();
            Console.WriteLine("Browser Closed");
            Console.WriteLine("Check Results Page Test Ends");
        }
        
    }
}
