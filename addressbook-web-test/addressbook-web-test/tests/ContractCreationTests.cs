using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace CB_AutoTests
{
    [TestFixture]
    public class ContractTestCase : AuthTestBase
    {
        [Test]
        public void ContractCreationTest()
        {
            app.Navigator.OpenAgreementPage();
            //app.Contacts.ContractCreation();
        }
    }
}
