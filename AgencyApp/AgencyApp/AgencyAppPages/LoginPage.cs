using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgencyApp.AppAgenCyPages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement textUserName => _driver.FindElement(By.XPath("//input[@id='Email']"));
        public IWebElement textPassword => _driver.FindElement(By.XPath("//input[@id='Password']"));
        public IWebElement loginBtn => _driver.FindElement(By.XPath("//button[contains(text(),'Log In')]"));


        public IWebElement logOut => _driver.FindElement(By.XPath("//div[@class='nav-item-topbar__user']"));
        public IWebElement logOutOne => _driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));

        public void ValidLogin(string uName, string pwd)
        {
            textUserName.SendKeys(uName);
            textPassword.SendKeys(pwd);
            loginBtn.Click();
        }

        public void LogOutfromApplication()
        {
            Thread.Sleep(5000);
            logOut.Click();
            Thread.Sleep(3000);
            logOutOne.Click();
            Thread.Sleep(3000);
        }
    }
}
