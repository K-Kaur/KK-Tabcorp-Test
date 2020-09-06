using KK_Tabcorp_KenoDigitalAutomationTest.Pages;
using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Testcases
{
    class KenoHomePageTestCases
    {
        static void Main(string[] args)
        {

        }
         
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.webdriver = new ChromeDriver();
            PropertiesCollection.webdriver.Navigate().GoToUrl("https://keno.com.au");
            PropertiesCollection.webdriver.Manage().Window.Maximize();

            Console.WriteLine("Keno Home Page Test Begins");
            Console.WriteLine("Opened Url");
        }
                
        [Test]
        public void TestCase1()
        {
            //Selecting VIC state

            KenoHomePage page = new KenoHomePage();            
            page.SelectState(states.VIC);

            PropertiesCollection.webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //confirming the correct jurisdiction is selected

            VicStateHomePage page1 = new VicStateHomePage();
            page1.confirmJurisdictions("VIC");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.webdriver.Close();
            Console.WriteLine("Browser Closed");
            Console.WriteLine("Keno Home Page Test Ends");
        }
        
    }
}
