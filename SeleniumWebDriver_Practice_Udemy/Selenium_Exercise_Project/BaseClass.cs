﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Selenium_Exercise_Project
{
    public class BaseClass
    {
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver chromeWebDriver = new ChromeDriver();
            return chromeWebDriver;
        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver ieDriver = new InternetExplorerDriver();
            return ieDriver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver firefoxDriver = new FirefoxDriver();
            return firefoxDriver;
        }
    }
}
