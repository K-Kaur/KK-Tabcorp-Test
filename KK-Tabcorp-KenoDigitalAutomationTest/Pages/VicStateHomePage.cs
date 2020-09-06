using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Pages
{
    class VicStateHomePage
    {
        //creating a page object for VIC State Home Page
        public VicStateHomePage()
        {
            PageFactory.InitElements(PropertiesCollection.webdriver, this);
        }

        //finding elements on VIC State Home Page

        //Check results page link
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/ui-view/headroom/navbar-top/nav/div[2]/ul[1]/li[2]/p/a")]
        public IWebElement checkResults { get; set; }

        //How to win page link
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/ui-view/headroom/navbar-top/nav/div[2]/ul[1]/li[3]/p/a")]
        public IWebElement howToWin { get; set; }

        //Find a venue page link 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/ui-view/headroom/navbar-top/nav/div[2]/ul[1]/li[4]/p/a")]
        //[FindsBy(How = How.PartialLinkText, Using = "Find a venue")]
        public IWebElement findVenue { get; set; }

        //Promotions page link 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/ui-view/headroom/navbar-top/nav/div[2]/ul[1]/li[5]/p/a")]
        public IWebElement promotions { get; set; }

        //Blog page link 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/ui-view/headroom/navbar-top/nav/div[2]/ul[1]/li[6]/p/a")]
        public IWebElement blog { get; set; }

        //FAQ page link 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/ui-view/headroom/navbar-top/nav/div[2]/ul[1]/li[7]/p/a")]
        public IWebElement faq { get; set; }

        //Jurisdiction Dropdown at the bottom of the page        
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/ui-view/navbar-btm/nav/div/div/ul[1]/li[2]/jurisdiction-dropdown/div/button")]
        public IWebElement jurisdictionDropDown { get; set; }

        //Verifying Check Results Link exist on the Page
        public bool checkResultsExist() => checkResults.Displayed;

        //Verifying How To Win Link exist on the Page
        public bool howToWinExist() => howToWin.Displayed;

        //Verifying Find Venue Link exist on the Page
        public bool findVenueExist() => findVenue.Displayed;

        //Verifying Promotions Link exist on the Page
        public bool promotionsExist() => promotions.Displayed;

        //Verifying Blog Link exist on the Page
        public bool blogExist() => blog.Displayed;

        //Verifying FAQ Link exist on the Page
        public bool faqExist() => faq.Displayed;


        //Selecting Find a Venue on VIC State Home Page and returning the page object
        public VicStateHomePage selectFindVenue()
        {
            findVenue.ClickElement();
            Console.WriteLine("Find a venue page link clicked and user is now on Find a venue page");

            return new VicStateHomePage();
        }

        //Selecting Check Results on VIC State Home Page and returning the page object
        public VicStateHomePage selectCheckResults()
        {
            checkResults.ClickElement();
            Console.WriteLine("Check results page link clicked and user is now on Check results page");

            return new VicStateHomePage();
        }

        //Verifying the Jurisdiction selected is correct
        public void confirmJurisdictions(string state)
        {
            var actualJurisdiction = jurisdictionDropDown.Text.ToUpper();
            if (actualJurisdiction == state.ToUpper())
            {
                Console.WriteLine(actualJurisdiction + " is the Actual Jurisdiction selected and it matches to the test state " + state);
            }
            else
            {
                Console.WriteLine(actualJurisdiction + " is the Actual Jurisdiction selected and it doesnot matches to the test state " + state);
            }
        }
    }
}
