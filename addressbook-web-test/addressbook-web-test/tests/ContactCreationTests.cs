using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactTestCase : AuthTestBase
    {
        public static IEnumerable<ContactData> RandomDataProvider()
        {
            List<ContactData> contact = new List<ContactData>();
            for (int i = 0; i < 5; i++)
            {
                contact.Add(new ContactData(GenerateRandonString(10), GenerateRandonString(10))
                {
                    MiddleName = GenerateRandonString(10),
                    Nickname = GenerateRandonString(10),
                    Title = GenerateRandonString(20),
                    Company = GenerateRandonString(20),
                    Address = GenerateRandonString(20),
                    Home = GenerateRandonString(10),
                    Mobile = GenerateRandonString(10),
                    Work = GenerateRandonString(10),
                    Fax = GenerateRandonString(10),
                    Email1 = GenerateRandonString(10),
                    Email2 = GenerateRandonString(10),
                    Email3 = GenerateRandonString(10),
                    HomePage = GenerateRandonString(20),
                    Address2 = GenerateRandonString(20),
                    Phone2 = GenerateRandonString(10),
                    Notes = GenerateRandonString(30)
                });
            }
            return contact;
        }

        [Test, TestCaseSource("RandomDataProvider")]
        public void ContactCreationTest(ContactData contact)
        {
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Creation(contact);

            Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();

            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
