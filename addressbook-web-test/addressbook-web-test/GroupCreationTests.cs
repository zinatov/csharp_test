using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            navigationHelper.Open_Homepage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitGroupCreation();
            GroupData group = new GroupData("first");
            group.Header = "second";
            group.Footer = "third";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmintGroupCreation();
            groupHelper.ReturnToGroupsPage();
        }
    }
}
