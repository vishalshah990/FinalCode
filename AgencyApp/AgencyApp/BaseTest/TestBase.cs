using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;

namespace AgencyApp.BaseTest
{
    public class TestBase
    {
        public static IWebDriver _driver;

        public void LaunchBrowser()
        {
             
            //string s1 = ConfigurationManager.AppSettings["url"];
            //Console.WriteLine(s1);

            // ChromeOptions option = new ChromeOptions();
            //option.AddArgument("--headless");

            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://agency-app-dev.azurewebsites.net/user/login.html");
        }

        public void CloseBrowser()
        {
            _driver.Quit();
        }

    }
}
