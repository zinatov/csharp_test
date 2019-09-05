using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CB_AutoTests
{
    [TestFixture]
    public class ContractTestCase : AuthTestBase
    {
        [Test]
        public void ContractCreationTest()
        {
            app.Navigator.OpenAgreementPage();
            app.Contracts.ContractCreation();
        }

        [Test]
        public void ContractRegistryTest()
        {
            app.Navigator.OpenAgreementPage();
            app.Contracts.ContractCreation();
            app.Contracts.ContractRegistry();
        }

        [Test]
        public void ContractRemoveTest()
        {
            app.Navigator.OpenAgreementPage();
            app.Contracts.ContractRemove();
        }

        [Test]
        public void OpenContractUserActionLog()
        {
            app.Navigator.OpenAgreementPage();
            app.Contracts.UserActionLog();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("h2.h4")), "Журнал операций");
        }

        [Test]
        public void OpenContractInfo()
        {
            app.Navigator.OpenAgreementPage();
            app.Contracts.OpenContractInfo();
          //  Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("h2.h4")), "Журнал операций");
        }

        [Test]
        public void OpenContract()
        {
            app.Navigator.OpenAgreementPage();
            app.Contracts.OpenContract();
         //   Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("h2.h4")), "Журнал операций");
        }

    }
}
