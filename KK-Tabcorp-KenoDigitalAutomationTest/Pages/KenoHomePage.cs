using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Pages
{
    class KenoHomePage
    {
        //creating a page object for Keno Home Page
        public KenoHomePage()
        {
            PageFactory.InitElements(PropertiesCollection.webdriver, this);
        }

        //finding elements on Keno Home Page

        //Select state dropdown
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div/div/jurisdiction-dropdown/div/button")]
        public IWebElement searchStateDropDown { get; set; }
        
        //VIC state from the dropdown
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div/div/jurisdiction-dropdown/div/ul/li[4]/a")]
        public IWebElement vicState { get; set; }

        //TAS state from the dropdown
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div/div/jurisdiction-dropdown/div/ul/li[8]/a")]
        public IWebElement tasState { get; set; }

        //Selecting a state based on the parameter passed from the test case.
        //Adding only 2 states for the purpose for this test
        public KenoHomePage SelectState(states state)
        {
            searchStateDropDown.ClickElement();
            Console.WriteLine("Dropdown expanded");

            if (state == states.VIC)
            {
                //vicState.ClickElement();
                vicState.Click();
                Console.WriteLine("VIC State is selected");                
            }
            //other states can be added in the similar way as below
            if (state == states.TAS)
            {
                tasState.ClickElement();
                Console.WriteLine("TAS State is selected");
            }
            return new KenoHomePage();
        }
        
    }
}
