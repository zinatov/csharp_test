using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            app.Contacts.ContactElementVerification();

            List<ContactData> oldContact = app.Contacts.GetContactList();
            app.Contacts.Remove(0);
            Thread.Sleep(2000);

            List<ContactData> newContact = app.Contacts.GetContactList();
            oldContact.RemoveAt(0);
            Assert.AreEqual(oldContact, newContact);
        }
    }
}
