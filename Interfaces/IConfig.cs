using SeleniumWebdriver1.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver1.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();//In browser type we already mentioned browser types.return type should be enum.
        string GetUserName();//going to read the user name for application.for login inside tha ppln.
        string GetPassword();
    }
}
