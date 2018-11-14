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
        public void TestContactInformationOnTable_Edit() //проверка информации о контакте на странице редактирования и на главное странице
        {
            ContactData fromTable =  app.Contacts.GetContactInfoFromView(0);
            ContactData fromEdit = app.Contacts.GetContactInfoFromEditForm(0);

            Assert.AreEqual(fromTable, fromEdit);
            Assert.AreEqual(fromTable.Address, fromEdit.Address);
            Assert.AreEqual(fromTable.AllPhones, fromEdit.AllPhones);
            Assert.AreEqual(fromTable.AllEmails, fromEdit.AllEmails);
        }

        [Test]
        public void ContactSearchCountTest()
        {
            int contactNumberOnPage = app.Contacts.GetContactCount();
            int contactNumberOnSearchResult = app.Contacts.GetNumberOfSearchResult();
            Assert.AreEqual(contactNumberOnPage, contactNumberOnSearchResult);
        }

        [Test]
        public void TestContactInformationOnView_Edit() //проерка информации о контакте на странице редактирования и на странице просмотра
        {
            //ContactData fromView = app.Contacts.GetContactInfoFromViewForm(0);
            ContactData fromEdit = app.Contacts.GetContactInfoFromEditForm(0);
            //Assert.AreEqual(fromView, fromEdit);
        }
    }
}