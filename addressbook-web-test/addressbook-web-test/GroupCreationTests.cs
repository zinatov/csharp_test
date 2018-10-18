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
            Open_Homepage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("first");
            group.Header = "second";
            group.Footer = "third";
            FillGroupForm(group);
            SubmintGroupCreation();
            ReturnToGroupsPage();
            LogOut();
        }
    }
}
