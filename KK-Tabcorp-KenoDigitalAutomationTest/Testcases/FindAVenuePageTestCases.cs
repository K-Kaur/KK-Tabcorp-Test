using KK_Tabcorp_KenoDigitalAutomationTest.Pages;
using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Testcases
{    
    class FindAVenuePageTestCases
    {
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.webdriver = new ChromeDriver();
            PropertiesCollection.webdriver.Navigate().GoToUrl("https://www.keno.com.au/venues/");
            PropertiesCollection.webdriver.Manage().Window.Maximize();

            Console.WriteLine("Find A Venue Page Test Begins");
            Console.WriteLine("Opened Url");
        }
                
        [Test]
        public void TestCase1()
        {
            //Selecting VIC State

            KenoHomePage page = new KenoHomePage();
            page.SelectState(states.VIC);

            PropertiesCollection.webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Searching for TAB in 3133 postcode
            //Verifying Wantirna Hill Club exist in search results
            //Verifying correct address is displayed for Wantirna Hill Club

            FindVenuePage page1 = new FindVenuePage();
            page1.searchTAB("3133");
            page1.wantirnaHillClubTABExist();
            page1.confirmTABDetails("715 Boronia Road, Wantirna, 3152, VIC, Australia");
            
        }
                
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.webdriver.Close();
            Console.WriteLine("Browser Closed");
            Console.WriteLine("Find A Venue Page Test Ends");
        }      

    }
}
