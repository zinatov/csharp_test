using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace CB_AutoTests
{
    public class ContractHelper : HelperBase
    {
        public ContractHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void ContractCreation()
        {
            OpenContractCreateForm();
            FillFormOnFirstTab();
            OpenNextTab();
            FillFormOnSecondTab();
            OpenNextTab();
            OpenNextTab();
            FillFormOnFouthTab();
            OpenNextTab();
            FillFormOnFifthTab();
            OpenNextTab();
            CloseContractCreationForm();
        }

        public void ContractRegistry()  //Зарегистрировать догоовр через подчтрочное меню реестра
        {
            WaitForElementLoad(By.LinkText("Зарегистрировать"), 10000);
            driver.FindElement(By.LinkText("Зарегистрировать")).Click();
        }

        public void UserActionLog()  //Отркытие формы просмотра журнала объекта 
        {
            WaitForElementLoad(By.LinkText("Журнал объекта"), 10000);
            driver.FindElement(By.LinkText("Журнал объекта")).Click();
        }

        public void OpenContractInfo()
        {
            WaitForElementLoad(By.LinkText("Сведения договора"), 10000);
            driver.FindElement(By.LinkText("Сведения договора")).Click();
        } //Открыть форму просмотра сведений договора

        public void ContractRemove()  //Удаление договора
        {
            WaitForElementLoad(By.LinkText("Журнал объекта"), 10000);
            driver.FindElement(By.XPath("//a[contains(text(),'Удалить')]")).Click();
        }

        public void OpenContract()
        {
            WaitForElementLoad(By.LinkText("Просмотр"), 10000);
            driver.FindElement(By.LinkText("Просмотр"));
        }  //Открыть форму просмотра договора

        public void CloseContractCreationForm() //Закрыть форму создания догвора
        {
            driver.FindElement(By.Name("saveAndExit")).Click();
        }

        public void FillFormOnFifthTab()   //заполнение данных на вкладке "Файлы"
        {   
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//a[contains(text(),'Добавить')])[5]")).Click();
            driver.FindElement(By.CssSelector("tr.k-grid-edit-row span.k-icon.k-i-arrow-s")).Click();
            driver.FindElement(By.CssSelector("#AttachmentType-list > span.k-list-filter > input.k-textbox")).Clear();
            driver.FindElement(By.CssSelector("#AttachmentType-list > span.k-list-filter > input.k-textbox")).SendKeys("авианакладная");
            driver.FindElement(By.CssSelector("#AttachmentType-list > span.k-list-filter > input.k-textbox")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='select'])[14]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='select'])[14]/following::input[1]")).Clear();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='select'])[14]/following::input[1]")).SendKeys("Номер договора");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='select'])[14]/following::input[1]")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("AttachmentId_uploader")).SendKeys("D:\\1.txt");
            driver.FindElement(By.CssSelector("a.k-button.k-button-icontext.k-primary.k-grid-update.icon.ic_update")).Click();
        }

        public void FillFormOnFouthTab()    //Заполнение данных на вкладке "Порядок расчета"
        {   
            driver.FindElement(By.CssSelector("#paymentSchedules > div.k-header.k-grid-toolbar.k-grid-top > a.k-button.k-button-icontext.k-grid-add")).Click();
            driver.FindElement(By.CssSelector("span[name=\"ExpenseName\"]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='[00000002]: СЗ в интересах административной деятельности'])[1]/preceding::span[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("td span span input")).SendKeys("1000");
            driver.FindElement(By.LinkText("Обновить")).Click();
        }

        public void OpenNextTab() //Переход на след вкладку на форме создания договора
        {
            driver.FindElement(By.LinkText("Далее")).Click();
            if (IsElementPresent(By.CssSelector("input.cc-yes.k-button")))
            {
                driver.FindElement(By.CssSelector("input.cc-yes.k-button")).Click();
            }
        }

        public void FillFormOnFirstTab()  //Заполнение данных на вкладке "Общие сведения"
        { 
            String ContractNumberName = "Номер договора" + " " + (DateTime.Now).ToString();
            String ContractDate = DateTime.Now.ToShortDateString();
            WaitForElementLoad(By.Id("Number"), 5000);
            driver.FindElement(By.Id("Number")).Click();
            driver.FindElement(By.Id("Number")).Clear();
            driver.FindElement(By.Id("Number")).SendKeys(ContractNumberName);
            //Заполнение даты договора
            driver.FindElement(By.XPath("//form[@id='mainform']/div/div[2]/div/span/span/span/span")).Click();
            driver.FindElement(By.LinkText("1")).Click();
            //Выбор способа закупки
            driver.FindElement(By.XPath("//div[5]/div/span/span/span")).Click();
            driver.FindElement(By.XPath("//ul[@id='PurchaseMethod_listbox']/li[1]")).Click();
            //Выбор пользователя ответсвенного за договор
            driver.FindElement(By.XPath("//span[@name='ResponsiblePersonName']")).Click();
            driver.FindElement(By.Id("responsibleSearchValue")).Click();
            driver.FindElement(By.Id("responsibleSearchValue")).Clear();
            driver.FindElement(By.Id("responsibleSearchValue")).SendKeys("autotest_user");
            driver.FindElement(By.XPath("//div[@id='responsiblePerson-window']/div/div/span/button/span")).Click();
            WaitForElementLoad(By.CssSelector("div#responsiblePerson-window tbody td"), 5000);
            driver.FindElement(By.CssSelector("div#responsiblePerson-window tbody td")).Click();
            //Выбор подразделения исполнителя
            driver.FindElement(By.XPath("//form[@id='mainform']/div/div[12]/div/div/div/input")).Click();
            driver.FindElement(By.CssSelector("span.k-icon.k-plus")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Департаменты'])[1]/following::span[2]")).Click();
            driver.FindElement(By.Id("select-executing-departments")).Click();
            //Заполнение поля Предмет договора
            driver.FindElement(By.Id("Subject")).Click();
            driver.FindElement(By.Id("Subject")).Clear();
            driver.FindElement(By.Id("Subject")).SendKeys("Предмет договора");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Поставщик (исполнитель, подрядчик)'])[1]/following::span[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='КПП'])[1]/following::td[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Наименование документа'])[1]/following::span[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='не задано'])[6]/following::li[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вид договора'])[1]/following::span[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='договор на выполнение научно-исследовательских работ'])[1]/following::li[1]")).Click();
            driver.FindElement(By.Id("Signatory")).Click();
            driver.FindElement(By.Id("Signatory")).Clear();
            driver.FindElement(By.Id("Signatory")).SendKeys("Подписант");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='select'])[7]/following::span[4]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вс'])[2]/following::a[31]")).Click();
        }

        public void FillFormOnSecondTab()   //Заполнение данных на вкладке "Цена договора"
        {
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Добавить")).Click();
            driver.FindElement(By.Id("ContractPrice")).Click();
            driver.FindElement(By.Id("ContractPrice")).Clear();
            driver.FindElement(By.Id("ContractPrice")).SendKeys("500000");
            driver.FindElement(By.CssSelector("a.k-button.k-button-icontext.k-primary.k-grid-update.icon.ic_update")).Click();

        }

        public void OpenContractCreateForm() //Открытие формы создания нового договора
        {
            WaitForElementLoad(By.LinkText("Добавить"), 10000);
            driver.FindElement(By.LinkText("Добавить")).Click();
        }
    }   
}