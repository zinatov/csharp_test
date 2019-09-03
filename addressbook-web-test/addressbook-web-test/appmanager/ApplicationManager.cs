using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace CB_AutoTests
{
    public class ApplicationManager
    {
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected ContractHelper contractHelper;
        protected IWebDriver driver;
        protected StringBuilder verificationErrors;


        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();


        private ApplicationManager()
        {
            driver = new InternetExplorerDriver();
            verificationErrors = new StringBuilder(); 

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this);
            contractHelper = new ContractHelper(this);
        }

        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstasnce = new ApplicationManager();
                newInstasnce.Navigator.OpenAuthPage();
                app.Value = newInstasnce;
            }
            return app.Value;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigationHelper;
            }
        }

        public ContractHelper Contacts
        {
            get
            {
                return contractHelper;
            }
         }
    }
}
