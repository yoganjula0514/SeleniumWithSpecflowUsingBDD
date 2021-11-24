using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Exercise_Project.Settings;

namespace Selenium_Exercise_Project.ComponentHelper
{
    public class WindowHelper
    {
        public static string GetTitle()
        {
            return ObjectRepository.WebDriver.Title;
        }
    }
}
