using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Exercise_Project.Interfaces;
using Selenium_Exercise_Project.Settings;

namespace Selenium_Exercise_Project.Configuration
{
    public class AppConfigurator : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            BrowserType browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browser);

            return browserType;
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }
    }
}
