using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium_Exercise_Project.ComponentHelper;
using Selenium_Exercise_Project.Settings;

namespace Selenium_Exercise_Project.TestScripts.HyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickOnHyperLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            try
            {
                var bestSellerHyperLinkWebElement = ObjectRepository.WebDriver.FindElement(By.LinkText("Best Sellers"));
                bestSellerHyperLinkWebElement.Click();

                var homeAndKitchenPartialLinkWebElement =
                    ObjectRepository.WebDriver.FindElement(By.PartialLinkText("Home &"));
                homeAndKitchenPartialLinkWebElement.Click();

                LinkHelper.ClickLink(By.LinkText("Customer Service"));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
