using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium_Exercise_Project.ComponentHelper;
using Selenium_Exercise_Project.Settings;

namespace Selenium_Exercise_Project.TestScripts.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void GetElement_From_AmazonWebsite()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            try
            {
                ObjectRepository.WebDriver.FindElement(By.TagName("Input"));
                ObjectRepository.WebDriver.FindElement(By.ClassName("celwidget"));
                ObjectRepository.WebDriver.FindElement(By.CssSelector("#glow-ingress-line2"));
                ObjectRepository.WebDriver.FindElement(By.LinkText("Amazon Pay"));
                ObjectRepository.WebDriver.FindElement(By.PartialLinkText("Home &"));
                ObjectRepository.WebDriver.FindElement(By.Name("field-keywords"));
                ObjectRepository.WebDriver.FindElement(By.Id("nav-search-submit-button"));
                ObjectRepository.WebDriver.FindElement(By.XPath("//select[@id='searchDropdownBox']"));
                //ObjectRepository.WebDriver.FindElement(By.XPath("//input[@id='email_1']"));

                IReadOnlyCollection<IWebElement> inputWebElements =
                    ObjectRepository.WebDriver.FindElements(By.TagName("input"));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
