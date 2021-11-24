using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium_Exercise_Project.ComponentHelper;
using Selenium_Exercise_Project.Settings;

namespace Selenium_Exercise_Project.TestScripts.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenYoutubeWebsite()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine($"Title of the page {WindowHelper.GetTitle()}");
        }
    }
}
