using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Exercise_Project.Configuration;

namespace Selenium_Exercise_Project.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();

        string GetUsername();

        string GetPassword();

        string GetWebsite();
    }
}
