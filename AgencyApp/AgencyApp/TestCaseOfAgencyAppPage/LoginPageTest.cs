using AgencyApp.AppAgenCyPages;
using AgencyApp.BaseTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AgencyApp.TestCaseOfAgencyAppPage
{
    public class LoginPageTest : TestBase
    {
        LoginPage loginpage;

        [OneTimeSetUp]
        public void OpenApplication()
        {
            LaunchBrowser();
            loginpage = new LoginPage(_driver);

        }

        [Test, Order(1)]
        public void TestValidLogin()
        {
            string s1 = "kishan@vesuviois.com";
            string s2 = "Abcd1#";
            loginpage.ValidLogin(s1, s2);
            Console.WriteLine(_driver.Title);
        }

        [Test, Order(2)]
        public void LogOutTest()
        {
            loginpage.LogOutfromApplication();
            CloseBrowser();
        }
    }
}
