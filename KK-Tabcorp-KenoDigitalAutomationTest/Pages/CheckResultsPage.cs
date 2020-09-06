using KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Text;

namespace KK_Tabcorp_KenoDigitalAutomationTest.Pages
{
    class CheckResultsPage
    {
        //creating a page object for Check results Page
        public CheckResultsPage()
        {
            PageFactory.InitElements(PropertiesCollection.webdriver, this);
        }

        //finding elements on Check Results Page

        //Check results date field
        [FindsBy(How = How.Id, Using = "checkResultsDate")]
        public IWebElement checkResultsDate { get; set; }
        
        //Start game text box
        [FindsBy(How = How.XPath, Using = "//*[@id='checkResultsGameNumber']")]
        public IWebElement startGame { get; set; }

        //Number Of Games text box
        [FindsBy(How = How.XPath, Using = "//*[@id='checkResultsNumOfGames']")]
        public IWebElement numberOfGames { get; set; }

        //Check results Button
        [FindsBy(How = How.Id, Using = "checkResults")]
        public IWebElement checkResultsButton { get; set; }


        //Entering details to check results
        public void enterDetailsToCheckResults(string date, string startgame, string numberofgames)
        {
            checkResultsDate.Clear();
            checkResultsDate.EnterText(date);
            Console.WriteLine(date + " is typed in as Date");

            startGame.Clear();
            startGame.EnterText(startgame);
            Console.WriteLine(startgame + " is typed in Start Game TextBox");

            numberOfGames.Clear();
            numberOfGames.EnterText(numberofgames);
            Console.WriteLine(numberofgames + " is typed in Number of Games TextBox");

            PropertiesCollection.webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            checkResultsButton.ClickElement();
            Console.WriteLine("Check results button is clicked");
                    
         }            
     }
 }

