﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Exercise_Project
{
    [TestClass]
    public class SeleniumWebDriverTests
    {
        [TestMethod]
        public void CreateSimpleWebDriver_OpenUdemyWebSite_And_CloseWebDriverAndQuit()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.udemy.com/";
            webDriver.Manage().Window.Maximize();
            webDriver.Close();
            webDriver.Quit();
        }
    }
}