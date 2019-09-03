using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace CB_AutoTests
{
    public class LoginHelper : HelperBase
    {
        
        public LoginHelper(ApplicationManager manager) : base(manager)  {
           
        }

        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }
                LogOut();
            }
            Type(By.Name("User"), account.Username);
            Type(By.Name("Password"), account.Password);
            driver.FindElement(By.XPath("(//input[@value='Войти'])[2]")).Click();
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Id("NotReadCount"));
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
                && GetLoggetUserName() == account.Username;
        }

        public string GetLoggetUserName()
        {
            string text = driver.FindElement(By.CssSelector("span.over_headerText")).Text;
            return text.Substring(text.IndexOf('(') + 1, text.Length - 2 - text.IndexOf('('));
        }

        public void LogOut()
        {
            if (IsLoggedIn())
            {
                driver.Url = "http://npaee.norbit.ru:" + PortNumberOfTestStand + "/Account/LogIn?sysconfig=1";
            }
        }
    }
}
