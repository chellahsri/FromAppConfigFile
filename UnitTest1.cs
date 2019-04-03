using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using SeleniumWebdriver1.Interfaces;
using SeleniumWebdriver1.Configuration;

namespace SeleniumWebdriver1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IConfig config = new AppConfigReader();//check interface chapter for more details
            //IConfig config = new XmlReader();
            Console.WriteLine("Browser: {0}", config.GetBrowser());
            Console.WriteLine("UserName: {0}", config.GetUserName());
            Console.WriteLine("Password: {0}", config.GetPassword());
        }   
        
    }
}
