using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactTestCase : ContactTestBase
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

        public static IEnumerable<ContactData> ContactDataFromXmlFile()
        {
            return (List<ContactData>)
                new XmlSerializer(typeof(List<ContactData>)).
                Deserialize(new StreamReader("C:\\Source\\Repos\\csharp_test\\addressbook-web-test\\addressbook-web-test\\contact.xml"));
        }

        public static IEnumerable<ContactData> ContactDataFromJsonFile()
        {
            return JsonConvert.DeserializeObject<List<ContactData>>(File.ReadAllText("C:\\Source\\Repos\\csharp_test\\addressbook-web-test\\addressbook-web-test\\contact.json"));
        }

        [Test, TestCaseSource("ContactDataFromJsonFile")]
        public void ContactCreationTest(ContactData contact)
        {
            List<ContactData> oldContacts = ContactData.GetAll();

            app.Contacts.Creation(contact);

            Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactCount());

            List<ContactData> newContacts = ContactData.GetAll();

            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
