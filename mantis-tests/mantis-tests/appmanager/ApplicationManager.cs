using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace mantis_tests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected StringBuilder verificationErrors;

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();


        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            verificationErrors = new StringBuilder();
            Registration = new RegistrationHelper(this);
            FTP = new FTPHelper(this);
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
                newInstasnce.driver.Url = "http://localhost/mantisbt-2.18.0/login_page.php";
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

        public RegistrationHelper Registration { get; set; }
        public FTPHelper FTP { get; set; }
    }
}
