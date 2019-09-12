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
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр потребностей");
        }

        [Test]
        public void OpenAgreementPageTest()
        {   //Проверка открытия ЕРД
            app.Navigator.OpenAgreementPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Единый реестр договоров");
        }

        [Test]
        public void OpenPlanItemPageTest()
        {   //Проверка открытия реестра лотов и ПЗ
            app.Navigator.OpenPlanItemPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр лотов и ПЗ");
        }

        [Test]
        public void OpenProcPlanningPageTest()
        {   //Проверка открытия реестра ГПЗ
            app.Navigator.OpenProcPlanningPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр годовых планов закупок");
        }

        //Название реестра в другом локаторе, нужно доработать
        [Test]
        public void OpenProcInitiatingPageTest()
        {   //Проверка открытия реестра ЗНЗ
            app.Navigator.OpenProcInitiatingPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Заявки на закупку");
        }

        [Test]
        public void OpenPurchaseInformationPageTest()
        {   //Проверка открытия реестра ЗНЗ
            app.Navigator.OpenPurchaseInformationPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр закупок");
        }

        [Test]
        public void OpenMemberPurchCommissionPageTest()
        {   //Проверка открытия реестра Члены комиссий
            app.Navigator.OpenMemberPurchCommissionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Члены комиссий");
        }

        [Test]
        public void OpenPurchCommissionPageTest()
        {   //Проверка открытия реестра Комиссии 
            app.Navigator.OpenPurchCommissionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Комиссии");
        }

        [Test]
        public void OpenVotingConclusionPageTest()
        {   //Проверка открытия реестра Проекты протоколов заседания комиссии
            app.Navigator.OpenVotingConclusionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Проекты протоколов заседания комиссии");
        }

        [Test]
        public void OpenVotingAgendaPageTest()
        {   //Проверка открытия реестра Повестки заседаний комиссии
            app.Navigator.OpenVotingAgendaPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Повестки заседаний комиссии");
        }

        [Test]
        public void OpenVotingBulletinPageTest()
        {   //Проверка открытия реестра Бюллетени комиссии
            app.Navigator.OpenVotingBulletinPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Бюллетени комиссии");
        }

        [Test]
        public void OpenApprovingNoticeCompetitionPageTest()
        {   //Проверка открытия реестра Утверждение извещений
            app.Navigator.OpenApprovingNoticeCompetitionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Утверждение извещений");
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void OpenBreakingPageTest()
        {   //Проверка открытия реестра Нарушения
            app.Navigator.OpenBreakingPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Нарушения");
        }

        [Test]
        public void OpenPrescriptionPageTest()
        {   //Проверка открытия реестра предписаний
            app.Navigator.OpenPrescriptionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр предписаний");
        }

        [Test]
        public void OpenComplaintPageTest()
        {   //Проверка открытия реестра жалоб
            app.Navigator.OpenComplaintPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Жалобы");
        }

        [Test]
        public void OpenComplaintSolutionPageTest()
        {   //Проверка открытия реестра решений по жалобам
            app.Navigator.OpenComplaintSolutionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Решения по жалобе");
        }

        [Test]
        public void OpenSupplierRegistryPageTest()
        {   //Проверка открытия реестра Реестр поставщиков
            app.Navigator.OpenSupplierRegistryPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Реестр поставщиков");
        }

        [Test]
        public void OpenProjectPurchCommissionPageTest()
        {   //Проверка открытия реестра проекта изменений комиссиий
            app.Navigator.OpenProjectPurchCommissionPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Проекты изменений комиссий");
        }

        [Test]
        public void OpenCalendarEventsPageTest()
        {   //Проверка открытия календаря событий
            app.Navigator.OpenCalendarEventsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Календарь событий");
        }

        [Test]
        public void OpenBackgroundTasksPageTest()
        {   //Проверка открытия фоновых задач
            app.Navigator.OpenBackgroundTasksPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Фоновые задачи");
        }

        [Test]
        public void OpenUsersPageTest()
        {   //Проверка открытия реестра пользователей
            app.Navigator.OpenUsersPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Пользователи");
        }

        [Test]
        public void OpenRolesPageTest()
        {   //Проверка открытия реестра ролей
            app.Navigator.OpenRolesPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Роли");
        }

        [Test]
        public void OpenOperationsPageTest()
        {   //Проверка открытия реестра Операции
            app.Navigator.OpenOperationsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Операции");
        }

        [Test]
        public void OpenLogTest()
        {   //Проверка открытия реестра Журнал пользовательских операций
            app.Navigator.OpenLogPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Журнал пользовательских операций");
        }

        [Test]
        public void OpenIntegrationInboxPageTest()
        {   //Проверка открытия реестра Входящие пакеты
            app.Navigator.OpenIntegrationInboxPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Входящие пакеты");
        }

        [Test]
        public void OpenIntegrationOutboxPageTest()
        {   //Проверка открытия реестра Исходящие пакеты
            app.Navigator.OpenIntegrationOutboxPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Исходящие пакеты");
        }

        [Test]
        public void OpenETPIntegrationPageTest()
        {   //Проверка открытия реестра Взаимодействие с УТП
            app.Navigator.OpenETPIntegrationPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Взаимодействие с УТП");
        }

        [Test]
        public void OpenServiceBusPageTest()
        {   //Проверка открытия реестра Журнал интеграции с ИП
            app.Navigator.OpenServiceBusPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Журнал интеграции с ИП");
        }

        [Test]
        public void OpenOrganizationsScopePageTest()
        {   //Проверка открытия реестра Группы организаций
            app.Navigator.OpenOrganizationsScopePage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Группы организаций");
        }

        [Test]
        public void OpenOrganizationsPageTest()
        {   //Проверка открытия реестра Иерархия заказчиков
            app.Navigator.OpenOrganizationsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Иерархия заказчиков");
        }

        [Test]
        public void OpenOrganizations_IndexContractorsPageTest()
        {   //Проверка открытия реестра Участники закупок
            app.Navigator.OpenOrganizations_IndexContractorsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Участники закупок");
        }

        [Test]
        public void OpenAdjustmentReasonPageTest()
        {   //Проверка открытия справочника Причины корректировки
            app.Navigator.OpenAdjustmentReasonPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Причины корректировки");
        }

        [Test]
        public void OpenCategoryStrategiesPageTest()
        {   //Проверка открытия справочника Категорийные стратегии
            app.Navigator.OpenCategoryStrategiesPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Категорийные стратегии");
        }

        [Test]
        public void OpenProductCategoriesPageTest()
        {   //Проверка открытия справочника Категории продукции (новый)
            app.Navigator.OpenProductCategoriesPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Категории продукции");
        }

        [Test]
        public void OpenProductCategoryPageTest()
        {   //Проверка открытия справочника Категории продукции
            app.Navigator.OpenProductCategoryPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Категории продукции");
        }

        [Test]
        public void OpenConditionComplaintPageTest()
        {   //Проверка открытия справочника Статусы жалоб
            app.Navigator.OpenConditionComplaintPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Статусы жалоб");
        }

        [Test]
        public void OpenExpertOpinionsPageTest()
        {   //Проверка открытия справочника Результаты экспертизы
            app.Navigator.OpenExpertOpinionsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Результаты экспертизы");
        }

        [Test]
        public void OpenPetitionsPageTest()
        {   //Проверка открытия справочника Ходатайства
            app.Navigator.OpenPetitionsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Ходатайства");
        }

        [Test]
        public void OpenAccreditedItemsPageTest()
        {   //Проверка открытия справочника Аккредитованные лица
            app.Navigator.OpenAccreditedItemsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Аккредитованные лица");
        }

        [Test]
        public void OpenRejectionReasonsPageTest()
        {   //Проверка открытия справочника Основания для отклонения
            app.Navigator.OpenRejectionReasonsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Основания для отклонения");
        }

        [Test]
        public void OpenWorkingStagesPageTest()
        {   //Проверка открытия справочника Этапы проведения закупки
            app.Navigator.OpenWorkingStagesPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Этапы проведения закупки");
        }

        [Test]
        public void OpenActivityKindsPageTest()
        {   //Проверка открытия справочника Виды деятельности
            app.Navigator.OpenActivityKindsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Виды деятельности");
        }

        [Test]
        public void OpenStatusPurchasePageTest()
        {   //Проверка открытия справочника Статусы закупки
            app.Navigator.OpenStatusPurchasePage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Статусы закупки");
        }

        [Test]
        public void OpenExchangeRatesPageTest()
        {   //Проверка открытия справочника Курсы валют
            app.Navigator.OpenExchangeRatesPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Курсы валют");
        }

        [Test]
        public void OpenBreakingRulesTypesPageTest()
        {   //Проверка открытия справочника Виды нарушений
            app.Navigator.OpenBreakingRulesTypesPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Виды нарушений");
        }

        [Test]
        public void OpenFailedPurchaseReasonPageTest()
        {   //Проверка открытия справочника Причины несостоявшихся закупок
            app.Navigator.OpenFailedPurchaseReasonPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Причины несостоявшихся закупок");
        }

        [Test]
        public void OpenExpensePageTest()
        {   //Проверка открытия справочника Статьи затрат
            app.Navigator.OpenExpensePage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Статьи затрат");
        }

        [Test]
        public void OpenGoodsWorksServicesTest()
        {   //Проверка открытия справочника Сведения о ТРУ
            app.Navigator.OpenGoodsWorksServicesPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Сведения о ТРУ");
        }

        [Test]
        public void OpenAreasOfBankingActivityPageTest()
        {   //Проверка открытия справочника Направления банковской деятельности
            app.Navigator.OpenAreasOfBankingActivityPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Направления банковской деятельности");
        }

        [Test]
        public void OpenPointProductionPurchasePageTest()
        {   //Проверка открытия справочника Основания закупки у ЕИ
            app.Navigator.OpenPointProductionPurchasePage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Основания закупки у ЕИ");
        }

        [Test]
        public void OpenContractTerminationReasonPageTest()
        {   //Проверка открытия справочника Основание расторжения договора
            app.Navigator.OpenContractTerminationReasonPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Основание расторжения договора");
        }

        [Test]
        public void OpenPenaltyReasonPageTest()
        {   //Проверка открытия справочника Основания штрафных санкций
            app.Navigator.OpenPenaltyReasonPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Основания штрафных санкций");
        }

        [Test]
        public void OpenTypePurchCommissionsPageTest()
        {   //Проверка открытия справочника Типы закупочной комиссии
            app.Navigator.OpenTypePurchCommissionsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Типы закупочной комиссии");
        }

        [Test]
        public void OpenContractsTypesPageTest()
        {   //Проверка открытия справочника Виды договоров
            app.Navigator.OpenContractsTypesPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Виды договоров");
        }

        [Test]
        public void OpenVotingQuestionTypesPageTest()
        {   //Проверка открытия справочника Типы вопросов комиссии
            app.Navigator.OpenVotingQuestionTypesPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Типы вопросов комиссии");
        }

        [Test]
        public void OpenVotingConclusionTypePageTest()
        {   //Проверка открытия справочника Типы протоколов заседания комиссии
            app.Navigator.OpenVotingConclusionTypePage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Типы протоколов заседания комиссии");
        }

        [Test]
        public void OpenComplaintReasonsPageTest()
        {   //Проверка открытия справочника Причины поступления жалоб
            app.Navigator.OpenComplaintReasonsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Причины поступления жалоб");
        }

        [Test]
        public void OpenCoordinationLogicControlPageTest()
        {   //Проверка открытия справочника Логические контроли
            app.Navigator.OpenCoordinationLogicControlPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Логические контроли");
        }

        [Test]
        public void OpenPurchaseEventTypePageTest()
        {   //Проверка открытия справочника События закупки
            app.Navigator.OpenPurchaseEventTypePage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "События закупки");
        }

        [Test]
        public void OpenSAPStatusLotPageTest()
        {   //Проверка открытия справочника Статусы лота
            app.Navigator.OpenSAPStatusLotPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Статусы лота");
        }

        [Test]
        public void OpenRequirementsPageTest()
        {   //Проверка открытия справочника Требования
            app.Navigator.OpenRequirementsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Требования");
        }

        [Test]
        public void OpenTableColumnHintPageTest()
        {   //Проверка открытия справочника Подсказки
            app.Navigator.OpenTableColumnHintPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Подсказки");
        }

        [Test]
        public void OpenSelectEvalCriteriasPageTest()
        {   //Проверка открытия справочника Критерии отбора и оценки
            app.Navigator.OpenSelectEvalCriteriasPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Критерии отбора и оценки");
        }

        [Test]
        public void OpenAssessmentDirectionsPageTest()
        {   //Проверка открытия справочника Направления оценки предложений
            app.Navigator.OpenAssessmentDirectionsPage();
            Assert.AreEqual(app.Navigator.TitleTextFromPage(), "Направления оценки предложений");
        }
    }
}