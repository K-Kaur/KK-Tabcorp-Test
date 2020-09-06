using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods
{
    public static class SetValueMethods
    {
        //Enter Text in an particular element Method
        public static void EnterText(this IWebElement element, string Text)
        {
            element.SendKeys(Text);
        }

        //Click an element
        public static void ClickElement(this IWebElement element)
        {
            element.Click();
        }

        //Selecting a value from DropDown element
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
