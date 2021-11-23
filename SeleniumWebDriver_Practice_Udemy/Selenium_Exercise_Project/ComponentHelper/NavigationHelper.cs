using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium_Exercise_Project.Settings;

namespace Selenium_Exercise_Project.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string url)
        {
            INavigation page = ObjectRepository.WebDriver.Navigate();
            page.GoToUrl(url);
        }
    }
}
