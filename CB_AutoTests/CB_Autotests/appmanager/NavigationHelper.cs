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
        public NavigationHelper(ApplicationManager manager) : base(manager)
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

        public string TitleTextFromPage()
        {
            string TitleText;
            if (IsElementPresent(By.CssSelector("h2.h4")))
            {
                TitleText = driver.FindElement(By.CssSelector("h2.h4")).Text;
            }
            else
            {
                TitleText = driver.FindElement(By.CssSelector("div.main-center-authorized.mainmenu-margin > h2")).Text;
            }
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

        public void OpenCalendarEventsPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-0"), By.CssSelector("li#MI_CalendarEvents"));
        }

        public void OpenBackgroundTasksPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-0"), By.CssSelector("li#MI_CalendarEvents a.ui-id-3"));
        }

        public void OpenUsersPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-1"), By.CssSelector("li#MI_Users"));
        }

        public void OpenRolesPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-1"), By.CssSelector("li#MI_Roles"));
        }

        public void OpenOperationsPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-1"), By.CssSelector("li#MI_Operations"));
        }

        public void OpenLogPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-1"), By.CssSelector("li#MI_Log"));
        }

        public void OpenIntegrationInboxPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-2"), By.CssSelector("li#MI_Exchange_Inbox"));
        }

        public void OpenIntegrationOutboxPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-2"), By.CssSelector("li#MI_Exchange_Outbox"));
        }

        public void OpenETPIntegrationPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-2"), By.CssSelector("li#MI_ETPIntegrationLog"));
        }

        public void OpenServiceBusPage()
        {
            OpenContextMenu(By.Id("ui-accordion-main-header-2"), By.CssSelector("li#MI_ServiceBusHub_Index"));
        }

        internal void OpenTypePurchCommissionsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenPenaltyReasonPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenContractTerminationReasonPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenPointProductionPurchasePage()
        {
            throw new NotImplementedException();
        }

        internal void OpenAreasOfBankingActivityPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenGoodsWorksServicesPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenExpensePage()
        {
            throw new NotImplementedException();
        }

        internal void OpenFailedPurchaseReasonPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenBreakingRulesTypesPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenOrganizationsScopePage()
        {
            throw new NotImplementedException();
        }

        internal void OpenExchangeRatesPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenStatusPurchasePage()
        {
            throw new NotImplementedException();
        }

        internal void OpenOrganizationsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenActivityKindsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenWorkingStagesPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenRejectionReasonsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenOrganizations_IndexContractorsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenAccreditedItemsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenPetitionsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenAdjustmentReasonPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenExpertOpinionsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenConditionComplaintPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenProductCategoryPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenCategoryStrategiesPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenProductCategoriesPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenContractsTypesPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenVotingQuestionTypesPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenVotingConclusionTypePage()
        {
            throw new NotImplementedException();
        }

        internal void OpenComplaintReasonsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenCoordinationLogicControlPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenPurchaseEventTypePage()
        {
            throw new NotImplementedException();
        }

        internal void OpenSAPStatusLotPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenRequirementsPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenTableColumnHintPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenSelectEvalCriteriasPage()
        {
            throw new NotImplementedException();
        }

        internal void OpenAssessmentDirectionsPage()
        {
            throw new NotImplementedException();
        }
    }
}
