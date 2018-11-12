using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactInformationTests : AuthTestBase
    {
        [Test]
        public void TestContactInformation()
        {
            ContactData fromTable =  app.Contacts.GetContactInfoFromTable(0);
            ContactData fromEdit = app.Contacts.GetContactInfoFromEditForm(0);

            Assert.AreEqual(fromTable, fromEdit);
            Assert.AreEqual(fromTable.Address, fromEdit.Address);
            Assert.AreEqual(fromTable.AllPhones, fromEdit.AllPhones);
            Assert.AreEqual(fromTable.AllEmails, fromEdit.AllEmails);
        }


    }
}