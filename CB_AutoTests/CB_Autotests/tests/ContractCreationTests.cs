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
            ContractData contract = new ContractData();
            contract.ContractNumber = "Номер договора" + " " + (DateTime.Now).ToString();
            contract.ContractDateDay = "10";
            contract.ContractDocumentNumberType = "Номер документа Авианакладная" + " " + (DateTime.Now).ToString();
            contract.ContractDocumentType = "авианакладная";
            contract.ContractPrice = "1000000";
            contract.ContractSubject = "Предмет договора";
            contract.ContractPaymentShedulePrice = "5000";
            contract.ContractNDSPrice = "1000";
            contract.ResponsiblePersonName = "autotest_user";
            contract.Signatory = "Подписант" + " " + (DateTime.Now).ToString();

            app.Navigator.OpenAgreementPage();
            app.Contracts.ContractCreation(contract);
        }

        [Test]
        public void ContractRegistryTest()
        {
            ContractData contract = new ContractData();
            contract.ContractNumber = "Договор для регистрации" + " " + (DateTime.Now).ToString();
            contract.ContractDateDay = "10";
            contract.ContractDocumentNumberType = "Номер документа Авианакладная" + " " + (DateTime.Now).ToString();
            contract.ContractDocumentType = "авианакладная";
            contract.ContractPrice = "1000000";
            contract.ContractSubject = "Предмет договора";
            contract.ContractPaymentShedulePrice = "5000";
            contract.ContractNDSPrice = "1000";
            contract.ResponsiblePersonName = "autotest_user";
            contract.Signatory = "Подписант" + " " + (DateTime.Now).ToString();

            app.Navigator.OpenAgreementPage();
            app.Contracts.ContractCreation(contract);
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

        [Test]
        public void Testmethod()
        {
            app.Navigator.OpenAgreementPage();
            app.Contracts.ContractFilterClear();
            Thread.Sleep(1000);
        }

    }
}
