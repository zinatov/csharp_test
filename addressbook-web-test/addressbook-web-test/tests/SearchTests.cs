using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class SearchTests : AuthTestBase
    {
        [Test]
        public void SearchNumber()
        {
            System.Console.Out.Write(app.Contacts.GetContactInfoFromViewForm(2));//GetNumberOfSearchResult());
        }
    }
}
