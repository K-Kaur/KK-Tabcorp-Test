using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Pages
{
    class FindVenuePage
    {
        //creating a page object for Find A Venue Page
        public FindVenuePage()
        {
            PageFactory.InitElements(PropertiesCollection.webdriver, this);
        }

        //finding elements on Find A Venue Page

        //Suburb, PostCode or City Search box
        [FindsBy(How = How.Id, Using = "venue-search")]
        public IWebElement venueSearchBox { get; set; }
                
        //TAB filtering link
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/ui-view/div[2]/div/div[2]/form/div/div[3]/ul/li[2]/a")]
        public IWebElement filterByTAB { get; set; }

        //Wantirna Hill Club search result
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/ui-view/div[2]/div/div[2]/ul/li[2]/a/div[1]/div[1]/h3")]
        public IWebElement wantirnaHillClub { get; set; }
        
        //Finding a venue using a Postcode
        public void searchTAB(string postcode)
        {
            filterByTAB.ClickElement();
            Console.WriteLine("TAB filter is clicked");
                                
            venueSearchBox.EnterText(postcode);
            venueSearchBox.SendKeys(Keys.Enter);
            Console.WriteLine("Postcode " + postcode + " is entered for search");

        }

        //Verifying Wantirna Hill Club exist in the search results for TAB in 3133 Postcode
        public bool wantirnaHillClubTABExist() => wantirnaHillClub.Displayed;

        //Confirming the address displayed for Wantirna Hill Club is correct
        public void confirmTABDetails(string testAddress)
        {
            IWebElement actualAddressElement = PropertiesCollection.webdriver.FindElement(By.XPath("/html/body/div[2]/ui-view/div[2]/div/div[2]/ul/li[2]/a/div[1]/div[1]/span"));
            var actualAddress = actualAddressElement.Text;
            if (actualAddress == testAddress)
            {
                Console.WriteLine("Address " + testAddress + " matches to " + actualAddress);
            }
            else
            {
                Console.WriteLine("Address " + testAddress + " do not match to " + actualAddress);
            }
        }
    }
}
