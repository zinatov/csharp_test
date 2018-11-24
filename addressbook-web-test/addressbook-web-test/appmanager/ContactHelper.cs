using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)  {
        }

        private List<ContactData> contactcache = null;

        public List<ContactData> GetContactList()
        {
            if (contactcache == null)
            {
                contactcache = new List<ContactData>();
                manager.Navigator.Open_Homepage();
                ICollection<IWebElement> elements = driver.FindElements(By.Name("entry"));
                foreach (IWebElement element in elements)
                {
                    var cells = element.FindElements(By.CssSelector("td"));
                    contactcache.Add(new ContactData(cells[2].Text, cells[1].Text)
                    {
                        Id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });
                }
            }
            return new List<ContactData>(contactcache);
        }

        public void RemoveContactFromGroup(ContactData contact)
        {
            manager.Navigator.Open_Homepage();
            setGroupFilter();
            SelectContact(contact.Id);
            CommitDeleteContactFromGroup();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(d => d.FindElements(By.CssSelector("div.msgbox")).Count > 0);
        }

        public void AddContactToGroup(ContactData contact, GroupData group)
        {
            manager.Navigator.Open_Homepage();
            ClearGroupFilter();
            SelectContact(contact.Id);
            SelectGroupToAdd(group.Name);
            CommitAddingContactToGroup();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(d => d.FindElements(By.CssSelector("div.msgbox")).Count > 0);
        }

        public void ContactElementVerification()
        {
            manager.Navigator.Open_Homepage();
            if (!IsContactExist())
            {
                ContactData contact = new ContactData("for_test_1", "for_test_2");
                Creation(contact);
            }
        }

        public ContactHelper Remove(int v)
        {
            manager.Navigator.Open_Homepage();
            SelectContact(v);
            DeleteContact();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper Remove(ContactData toBeRemoved)
        {
            manager.Navigator.Open_Homepage();
            SelectContact(toBeRemoved.Id);
            DeleteContact();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper Modification(int v, ContactData newData)
        {
            manager.Navigator.Open_Homepage();
            InitContactModification(v);
            FillContactForm(newData);
            SubmintContactModification();
            manager.Navigator.Open_Homepage();
            return this;
        }

        public ContactHelper Modified(ContactData toBeModify, ContactData newData)
        {
            manager.Navigator.Open_Homepage();
            InitContactModification(toBeModify.Id);
            FillContactForm(newData);
            SubmintContactModification();
            manager.Navigator.Open_Homepage();
            return this;
        }

        public ContactHelper Creation(ContactData contact)
        {
            manager.Navigator.Open_Homepage();
            InitContactCreation();
            FillContactForm(contact);
            SubmintContactCreation();         
            manager.Navigator.GoToHomePage();
            return this;
        }
        public ContactData GetContactInfoFromView(int v)
        {
            manager.Navigator.Open_Homepage();
            IList<IWebElement> cells = driver.FindElements(By.Name("entry"))[v].FindElements(By.TagName("td"));
            string lastName = cells[1].Text;
            string firstName = cells[2].Text;
            string address = cells[3].Text;
            string allEmail = cells[4].Text;
            string allPhones = cells[5].Text;

            return new ContactData(firstName, lastName)
            {
                Address = address,
                AllPhones = allPhones,
                AllEmails = allEmail,
            };
        }

        public int GetNumberOfSearchResult()
        {
            manager.Navigator.Open_Homepage();
            string number = driver.FindElement(By.CssSelector("span#search_count")).Text;
            return Int32.Parse(number);
        }

        public ContactData GetContactInfoFromEditForm(int v)
        {
            manager.Navigator.Open_Homepage();
            InitContactModification(v);
            string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
            string lastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
            string address = driver.FindElement(By.Name("address")).GetAttribute("value");

            string homePhone = driver.FindElement(By.Name("home")).GetAttribute("value");
            string mobilePhone = driver.FindElement(By.Name("mobile")).GetAttribute("value");
            string workPhone = driver.FindElement(By.Name("work")).GetAttribute("value");
            string secondPhone = driver.FindElement(By.Name("phone2")).GetAttribute("value");

            string email1 = driver.FindElement(By.Name("email")).GetAttribute("value");
            string email2 = driver.FindElement(By.Name("email2")).GetAttribute("value");
            string email3 = driver.FindElement(By.Name("email3")).GetAttribute("value");

            return new ContactData(firstName, lastName)
            {
                Address = address,
                Home = homePhone,
                Mobile = mobilePhone,
                Work = workPhone,
                Email1 = email1,
                Email2 = email2,
                Email3 = email3,
                Phone2 = secondPhone
            };
        }

        public string GetContactInfoFromEditFormForView(int v)
        {
            manager.Navigator.Open_Homepage();
            InitContactModification(v);
            string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
            string middleName = driver.FindElement(By.Name("middlename")).GetAttribute("value");
            string lastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
            string nickName = driver.FindElement(By.Name("nickname")).GetAttribute("value");

            string title = driver.FindElement(By.Name("title")).GetAttribute("value");
            string company = driver.FindElement(By.Name("company")).GetAttribute("value");
            string address = driver.FindElement(By.Name("address")).GetAttribute("value");

            string homePhone = driver.FindElement(By.Name("home")).GetAttribute("value");
            string mobilePhone = driver.FindElement(By.Name("mobile")).GetAttribute("value");
            string workPhone = driver.FindElement(By.Name("work")).GetAttribute("value");
            string fax = driver.FindElement(By.Name("fax")).GetAttribute("value");

            string email1 = driver.FindElement(By.Name("email")).GetAttribute("value");
            string email2 = driver.FindElement(By.Name("email2")).GetAttribute("value");
            string email3 = driver.FindElement(By.Name("email3")).GetAttribute("value");

            string homepage = driver.FindElement(By.Name("homepage")).GetAttribute("value");
            string address2 = driver.FindElement(By.Name("address2")).GetAttribute("value");
            string phone2 = driver.FindElement(By.Name("phone2")).GetAttribute("value");
            string notes = driver.FindElement(By.Name("notes")).GetAttribute("value");


            return (firstName + " " + middleName + " " + lastName + "\r\n"
                         + nickName + "\r\n"
                         + title + "\r\n"
                         + company + "\r\n"
                         + address + "\r\n\r\n"
                         + "H: " + homePhone + "\r\n"
                         + "M: " + mobilePhone + "\r\n"
                         + "W: " + workPhone + "\r\n"
                         + "F: " + fax + "\r\n\r\n"
                         + email1 + "\r\n"
                         + email2 + "\r\n"
                         + email3 + "\r\n"
                         + "Homepage:" + "\r\n" + homepage + "\r\n\r\n\r\n"
                         + address2 + "\r\n\r\n"
                         + "P: " + phone2 + "\r\n\r\n"
                         + notes
                         ).Trim();
        }

        public string GetContactInfoFromViewForm(int v)
        {
            manager.Navigator.Open_Homepage();
            OpenContactViewForm(v);
            string fullInfo = driver.FindElement(By.Id("content")).Text;
            return fullInfo;
        }


        public ContactHelper OpenContactViewForm(int v)
        {
            driver.FindElement(By.XPath("(//img[@alt='Details'])[" + (v + 1) + "]")).Click();
            return this;
        }

        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Name);
            Type(By.Name("middlename"), contact.MiddleName);
            Type(By.Name("lastname"), contact.LastName);
            Type(By.Name("nickname"), contact.Nickname);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.Home);
            Type(By.Name("mobile"), contact.Mobile);
            Type(By.Name("work"), contact.Work);
            Type(By.Name("fax"), contact.Fax);
            Type(By.Name("email"), contact.Email1);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("email3"), contact.Email3);
            Type(By.Name("homepage"), contact.HomePage);
            Type(By.Name("address2"), contact.Address2);
            Type(By.Name("phone2"), contact.Phone2);
            Type(By.Name("notes"), contact.Notes);
            return this;
        }

        public ContactHelper SelectContact(int v)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (v + 1) + "]")).Click();
            return this;
        }


        public ContactHelper SelectContact(string contactId)
        {
            driver.FindElement(By.Id(contactId)).Click();
            return this;
        }

        public ContactHelper DeleteContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            contactcache = null;
            return this;
        }

        public ContactHelper InitContactModification(int v)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + (v + 1) + "]")).Click();
            return this;
        }

        public ContactHelper InitContactModification(string v)
        {
            string URL = "(//a[@href='edit.php?id="+ v + "'])"; 
            driver.FindElement(By.XPath(URL)).Click();
            return this;
        }

        public ContactHelper SubmintContactModification()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            contactcache = null;
            return this;
        }

        public ContactHelper SubmintContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            contactcache = null;
            return this;
        }

        public int GetContactCount()
        {
            return driver.FindElements(By.Name("entry")).Count;
        }

        private void CommitAddingContactToGroup()
        {
            driver.FindElement(By.Name("add")).Click();
        }

        private void SelectGroupToAdd(string name)
        {
            new SelectElement(driver.FindElement(By.Name("to_group"))).SelectByText(name);
        }

        private void ClearGroupFilter()
        {
            new SelectElement(driver.FindElement(By.Name("group"))).SelectByText("[all]");
        }

        private void CommitDeleteContactFromGroup()
        {
            driver.FindElement(By.Name("remove")).Click();
        }

        private void setGroupFilter()
        {
            new SelectElement(driver.FindElement(By.Name("group"))).SelectByText("TestGroup");
        }

        private bool IsContactExist()
        {
            return IsElementPresent(By.Name("entry"));
        }
    }
}
