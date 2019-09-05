using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace CB_AutoTests
{
    [TestFixture]
    public class NavigationTests : AuthTestBase
    {

        [Test]
        public void OpenDesirePageTest()
        {   //Проверка открытия реестра потреностей
            app.Navigator.OpenDesirePage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("h2.h4")), "Реестр потребностей");
        }

        [Test]
        public void OpenAgreementPageTest()
        {   //Проверка открытия ЕРД
            app.Navigator.OpenAgreementPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("h2.h4")), "Единый реестр договоров");
        }

        [Test]
        public void OpenPlanItemPageTest()
        {   //Проверка открытия реестра лотов и ПЗ
            app.Navigator.OpenPlanItemPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("h2.h4")), "Реестр лотов и ПЗ");
        }

        [Test]
        public void OpenProcPlanningPageTest()
        {   //Проверка открытия реестра ГПЗ
            app.Navigator.OpenProcPlanningPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("h2.h4")), "Реестр годовых планов закупок");
        }

        //Название реестра в другом локаторе, нужно доработать
        [Test]
        public void OpenProcInitiatingPageTest()
        {   //Проверка открытия реестра ЗНЗ
            app.Navigator.OpenProcInitiatingPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Заявки на закупку");
        }

        [Test]
        public void OpenPurchaseInformationPageTest()
        {   //Проверка открытия реестра ЗНЗ
            app.Navigator.OpenPurchaseInformationPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("h2.h4")), "Реестр закупок");
        }

        [Test]
        public void OpenMemberPurchCommissionPageTest()
        {   //Проверка открытия реестра Члены комиссий
            app.Navigator.OpenMemberPurchCommissionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Члены комиссий");
        }

        [Test]
        public void OpenPurchCommissionPageTest()
        {   //Проверка открытия реестра Комиссии 
            app.Navigator.OpenPurchCommissionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Комиссии");
        }

        [Test]
        public void OpenVotingConclusionPageTest()
        {   //Проверка открытия реестра Проекты протоколов заседания комиссии
            app.Navigator.OpenVotingConclusionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Проекты протоколов заседания комиссии");
        }

        [Test]
        public void OpenVotingAgendaPageTest()
        {   //Проверка открытия реестра Повестки заседаний комиссии
            app.Navigator.OpenVotingAgendaPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Повестки заседаний комиссии");
        }

        [Test]
        public void OpenVotingBulletinPageTest()
        {   //Проверка открытия реестра Бюллетени комиссии
            app.Navigator.OpenVotingBulletinPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Бюллетени комиссии");
        }

        [Test]
        public void OpenApprovingNoticeCompetitionPageTest()
        {   //Проверка открытия реестра Утверждение извещений
            app.Navigator.OpenApprovingNoticeCompetitionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Утверждение извещений");
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void OpenBreakingPageTest()
        {   //Проверка открытия реестра Нарушения
            app.Navigator.OpenBreakingPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Нарушения");
        }

        [Test]
        public void OpenPrescriptionPageTest()
        {   //Проверка открытия реестра предписаний
            app.Navigator.OpenPrescriptionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Реестр предписаний");
        }

        [Test]
        public void OpenComplaintPageTest()
        {   //Проверка открытия реестра жалоб
            app.Navigator.OpenComplaintPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Жалобы");
        }

        [Test]
        public void OpenComplaintSolutionPageTest()
        {   //Проверка открытия реестра решений по жалобам
            app.Navigator.OpenComplaintSolutionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Решения по жалобе");
        }

        [Test]
        public void OpenSupplierRegistryPageTest()
        {   //Проверка открытия реестра Реестр поставщиков
            app.Navigator.OpenSupplierRegistryPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Реестр поставщиков");
        }

        [Test]
        public void OpenApplicationContractorPageTest()
        {   //Проверка открытия реестра недобросовестных поставщиков
            app.Navigator.OpenApplicationContractorPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("li#UnfairContractorIncluded a")), "Реестр недобросовестных поставщиков");
        }

        [Test]
        public void OpenProjectPurchCommissionPageTest()
        {   //Проверка открытия реестра проекта изменений комиссиий
            app.Navigator.OpenProjectPurchCommissionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")), "Проекты изменений комиссий");
        }

    }
}