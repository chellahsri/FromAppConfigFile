using SeleniumWebdriver1.Interfaces;
using SeleniumWebdriver1.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver1.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser() 
        {
            //convert the string value to enum hence this return type is enum.
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            //typecat to the enum type
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);//returning a object.typecast to the browser type
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserName);
        }
    }
}
