using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace CB_AutoTests
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(ApplicationManager manager) :base(manager)
        {
        }

        public void OpenAuthPage()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "http://npaee.norbit.ru:" + PortNumberOfTestStand + "/Account/LogIn?sysconfig=1";
        }

        public string TitleTextFromPage(By by)
        {
            string TitleText = driver.FindElement(by).Text;
            return TitleText;
        }

        public void OpenProcPlanningPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Реестр потребностей'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Реестр ГПЗ')]")).Click();
        }

        public void OpenPlanItemPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Реестр потребностей'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("//li[@id='MI_PlanItemAndLotRegister']/a")).Click();
        }

        public void OpenProcInitiatingPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Заявки на закупку'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Инициирование закупок'])[1]/following::a[1]")).Click();
        }

        public void OpenPurchaseInformationPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Реестр закупок'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.LinkText("Реестр закупок")).Click();
        }

        public void OpenAgreementPage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Единый реестр договоров'])[2]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Единый реестр договоров'])[1]/following::a[1]")).Click();
        }

        public void OpenDesirePage()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Реестр потребностей'])[1]/preceding::h3[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='hidden'])[3]/following::a[1]")).Click();
        }

        public void OpenPurchCommissionPage()
        {
            driver.FindElement(By.Id("ui-accordion-main-header-11")).Click();
            driver.FindElement(By.XPath("//a[contains(@href, '/References/PurchCommission')]")).Click();
        }

        public void OpenVotingConclusionPage()
        {
            driver.FindElement(By.XPath("(//a[contains(@href, '/ZK/VotingConclusion')])[2]")).Click();
        }

        public void OpenVotingAgendaPage()
        {
            // driver.FindElement(By.Id("ui-accordion-main-header-11")).Click();
            driver.FindElement(By.XPath("//a[contains(@href, '/ZK/VotingAgenda')]")).Click();
        }

        public void OpenProtocolVotingConclusionPage()
        {
            driver.FindElement(By.Id("ui-accordion-main-header-11")).Click();
            driver.FindElement(By.XPath("//a[contains(@href, '/ZK/ProtocolVotingConclusion')]")).Click();
        }

        public void OpenVotingBulletinPage()
        {
            driver.FindElement(By.XPath("//a[contains(@href, '/ZK/VotingBulletin')]")).Click();
        }

        public void OpenMemberPurchCommissionPage()
        {
            driver.FindElement(By.Id("ui-accordion-main-header-11")).Click();
            driver.FindElement(By.XPath("//a[contains(@href, '/References/MemberPurchCommission')]")).Click();
        }

        public void OpenApprovingNoticeCompetitionPage()
        {
            driver.FindElement(By.Id("ui-accordion-main-header-11")).Click();
            driver.FindElement(By.XPath("//a[contains(@href, '/ZK/ApprovingNoticeCompetition')]")).Click();
        }
    }
}
