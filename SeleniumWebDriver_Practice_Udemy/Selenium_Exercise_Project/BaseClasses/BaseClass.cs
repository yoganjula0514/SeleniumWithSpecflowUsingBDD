using System;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Selenium_Exercise_Project.Configuration;
using Selenium_Exercise_Project.CustomException;
using Selenium_Exercise_Project.Settings;

namespace Selenium_Exercise_Project.BaseClasses
{
    [TestClass]
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

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepository.Config=new AppConfigReader();

            var browserType = ObjectRepository.Config.GetBrowser();
            switch (browserType)
            {
                case BrowserType.Chrome:
                    ObjectRepository.WebDriver = GetChromeDriver();
                    break;

                case BrowserType.IE:
                    ObjectRepository.WebDriver = GetIEDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.WebDriver = GetFirefoxDriver();
                    break;

                default:
                    throw new NoSuitableDriverFound($"'{browserType.ToString()}' not found.");
            }
        }
    }
}
