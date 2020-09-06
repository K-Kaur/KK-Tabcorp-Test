using KK_Tabcorp_KenoDigitalAutomationTest.Pages;
using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Testcases
{
    class VícStateHomePageTestCases
    {
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.webdriver = new ChromeDriver();
            PropertiesCollection.webdriver.Navigate().GoToUrl("https://www.keno.com.au/");
            PropertiesCollection.webdriver.Manage().Window.Maximize();

            Console.WriteLine("Víc State Home Page Test Begins");
            Console.WriteLine("Opened Url");
        }

        [Test]
        public void TestCase1()
        {
            //Selecting VIC state

            KenoHomePage page = new KenoHomePage();
            page.SelectState(states.VIC);

            PropertiesCollection.webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Verifying elements exist on VIC State's Home Page

            VicStateHomePage page1 = new VicStateHomePage();
            page1.checkResultsExist();
            page1.howToWinExist();
            page1.findVenueExist();
            page1.promotionsExist();
            page1.blogExist();
            page1.faqExist();
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.webdriver.Close();
            Console.WriteLine("Browser Closed");
            Console.WriteLine("Víc State Home Page Test Ends");
        }
    }
}
