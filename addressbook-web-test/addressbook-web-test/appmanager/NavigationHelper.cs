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
        
        //Процедура открытия подпункта меню. 
        //Например: для открытия реестра лотов и пз, проверяется, раскрыт ли пункт меню Планирование, 
        //если да, то открывается подпункт меню "Реестр лотов и пз", если нет, то сначала раскрывается пункт меню "Реестр лотов и ПЗ"
        private void OpenContextMenu(By byMenu, By byContextMenu)
        {
            if (!IsElementDispayed(byContextMenu))
            {
                driver.FindElement(byMenu).Click();
            }
            driver.FindElement(byContextMenu).Click();
        }

        public string TitleTextFromPage(By by)
        {
            string TitleText = driver.FindElement(by).Text;
            return TitleText;
        }

        public void OpenProcPlanningPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-8"), By.CssSelector("li#MI_ProcurementPlanRegister"));
        }

        public void OpenPlanItemPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-8"), By.CssSelector("li#MI_PlanItemAndLotRegister"));
        }

        public void OpenProcInitiatingPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-9"), By.CssSelector("li#MI_ProcurementInitiating"));
        }

        public void OpenPurchaseInformationPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-10"), By.CssSelector("li#MI_PurchaseInformationRegister"));
        }

        public void OpenAgreementPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-15"), By.CssSelector("ul#Agreements li"));
        }
        
        public void OpenDesirePage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-8"), By.CssSelector("li#MI_DesiresRegister"));
        }

        public void OpenPurchCommissionPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-11"), By.XPath("//a[contains(@href, '/References/PurchCommission')]"));
        }

        public void OpenVotingConclusionPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-11"), By.XPath("(//a[contains(@href, '/ZK/VotingConclusion')])[2]"));
        }

        public void OpenVotingAgendaPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-11"), By.XPath("//a[contains(@href, '/ZK/VotingAgenda')]"));
        }

        public void OpenProtocolVotingConclusionPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-11"), By.XPath("//a[contains(@href, '/ZK/VotingAgenda')]"));
        }

        public void OpenVotingBulletinPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-11"), By.XPath("//a[contains(@href, '/ZK/VotingBulletin')]"));
        }

        public void OpenMemberPurchCommissionPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-11"), By.XPath("//a[contains(@href, '/References/MemberPurchCommission')]"));
        }

        public void OpenApprovingNoticeCompetitionPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-11"), By.XPath("//a[contains(@href, '/ZK/ApprovingNoticeCompetition')]"));
        }


        public void OpenPrescriptionPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-17"), By.CssSelector("li#MI_Prescription"));
        }

        public void OpenBreakingPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-17"), By.CssSelector("li#MI_Breaking"));
        }

        public void OpenComplaintPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-18"), By.CssSelector("li#MI_Complaint"));
        }

        public void OpenComplaintSolutionPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-18"), By.CssSelector("li#MI_ComplaintSolution"));
        }

        public void OpenSupplierRegistryPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-19"), By.CssSelector("li#MI_SupplierRegistry"));
        }

        public void OpenApplicationContractorPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-19"), By.CssSelector("li#MI_ApplicationContractor"));
        }

        public void OpenProjectPurchCommissionPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-20"), By.CssSelector("li#MI_ProjectPurchCommission"));
        }
    }
}
