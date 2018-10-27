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
        public void ContactCreationTest()
        {
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
            app.Contacts.Creation(contact);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("", "");
            app.Contacts.Creation(contact);
        }
    }
}
