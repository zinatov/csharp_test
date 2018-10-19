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
            app.Navigator.Open_Homepage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitGroupCreation();
            GroupData group = new GroupData("first");
            group.Header = "second";
            group.Footer = "third";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmintGroupCreation();
            app.Groups.ReturnToGroupsPage();
        }
    }
}
