using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
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
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");

            return chromeOptions;
        }

        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions internetExplorerOptions = new InternetExplorerOptions();
            internetExplorerOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            internetExplorerOptions.EnsureCleanSession = true;

            return internetExplorerOptions;
        }

        private static FirefoxProfile GetFirefoxOptions()
        {
            FirefoxProfile firefoxProfile = new FirefoxProfile();
            FirefoxProfileManager firefoxProfileManager = new FirefoxProfileManager();
            firefoxProfile = firefoxProfileManager.GetProfile("default");

            return firefoxProfile;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver chromeWebDriver = new ChromeDriver(GetChromeOptions());
            return chromeWebDriver;
        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver ieDriver = new InternetExplorerDriver(GetIEOptions());
            return ieDriver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver firefoxDriver = new FirefoxDriver();
            //IWebDriver firefoxDriver = new FirefoxDriver(GetFirefoxOptions()));
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

        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.WebDriver != null)
            {
                ObjectRepository.WebDriver.Close();
                ObjectRepository.WebDriver.Quit();
            }
        }
    }
}
