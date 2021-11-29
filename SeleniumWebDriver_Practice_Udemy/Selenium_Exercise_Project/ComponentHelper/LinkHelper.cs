using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_Exercise_Project.ComponentHelper
{
    public class LinkHelper
    {
        private static IWebElement m_WebElement;

        public static void ClickLink(By locator)
        {
            m_WebElement = GenericHelper.GetWebElement(locator);
            m_WebElement.Click();
        }
    }
}
