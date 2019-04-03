using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver1.Configuration
{
    public enum BrowserType
    {
        Firefox,
        Chrome,
        IExplorer //It is a named constant because internally the compiler is going to assing the value to each of them.starting from 0
    }
}
