using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            app.Contacts.ContactElementVerification();

            ContactData newData = new ContactData("modify_ivan", "modify_ivanov");
            newData.MiddleName = "Modify_Ivanovich";
            newData.Nickname = "Modify_Ivan1234";
            newData.Title = "Modify_Title";
            newData.Company = "Modify_Company";
            newData.Address = "Modify_Address";
            newData.Home = "Modify_89229229222";
            newData.Mobile = "Modify_89129129122";
            newData.Work = "Modify_89029029022";
            newData.Fax = "Modify_888888888888";
            newData.Email1 = "Modify_Ivanov123@imail.ru";
            newData.Email2 = "Modify_Ivanov321@imail.ru";
            newData.Email3 = "Modify_Ivanov432@imail.ru";
            newData.HomePage = "Modify_ivanovHomepage.Ru";
            newData.Address2 = "Modify_second address";
            newData.Phone2 = "Modify_second home";
            newData.Notes = "Modify_second note";

            List<ContactData> oldContact = app.Contacts.GetContactList();

            app.Contacts.Modification(0, newData);

            List<ContactData> newContact = app.Contacts.GetContactList();
            oldContact[0].LastName = newData.LastName;
            oldContact[0].Name = newData.Name;
            oldContact.Sort();
            newContact.Sort();
            Assert.AreEqual(oldContact, newContact);

        }
    }
}
