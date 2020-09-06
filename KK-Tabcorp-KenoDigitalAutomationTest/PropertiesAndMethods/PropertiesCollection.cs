using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KK_Tabcorp_KenoDigitalAutomationTest.PropertiesAndMethods
{
    //Enumeration for all the states
    enum states
    {
        ACT,
        NSW,
        QLD,
        VIC,
        WA,
        NT,
        SA,
        TAS
    }

    //Global Webdriver that can be used throughout the project
    class PropertiesCollection
    {
        public static IWebDriver webdriver { get; set; }
    }
}
