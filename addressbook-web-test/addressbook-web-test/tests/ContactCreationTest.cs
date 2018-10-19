using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactTestCase : TestBase
    {
        [Test]
        public void TheContactTestCaseTest()
        {
            app.Navigator.Open_Homepage();
            app.Auth.Login(new AccountData ("admin", "secret"));
            app.Contacts.InitContactCreation();

            ContactData contact = new ContactData("ivan", "ivanov");
            contact.MiddleName = "Ivanovich";
            contact.Nickname = "Ivan1234";
            contact.Title = "Title";
            contact.Company = "Company";
            contact.Address = "Address";
            contact.Home = "89229229222";
            contact.Mobile = "89129129122";
            contact.Work = "89029029022";
            contact.Fax = "888888888888";
            contact.Email1 = "Ivanov123@imail.ru";
            contact.Email2 = "Ivanov321@imail.ru";
            contact.Email3 = "Ivanov432@imail.ru";
            contact.HomePage = "ivanovHomepage.Ru";
            contact.Address2 = "second address";
            contact.Phone2 = "second home";
            contact.Notes = "second note";
            contact.AYear = "1994";
            contact.AMonth = "September";
            contact.ADay = "12";
            contact.BYear = "1978";
            contact.BMonth = "July";
            contact.BDay = "10";
            contact.Path = "C:\\1.png";

            app.Contacts.FillContactForm(contact);
            app.Contacts.SubmintContactCreation();
            app.Navigator.GoToHomePage();
        }
    }
}
