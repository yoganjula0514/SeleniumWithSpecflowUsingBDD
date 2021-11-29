using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium_Exercise_Project.Settings;

namespace Selenium_Exercise_Project.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return ObjectRepository.WebDriver.FindElements(locator).Count == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static IWebElement GetWebElement(By locator)
        {
            if (IsElementPresent(locator))
            {
                return ObjectRepository.WebDriver.FindElement(locator);
            }

            throw new NoSuchElementException($"Web element is not found : {locator}");
        }
    }
}
