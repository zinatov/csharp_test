﻿using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using System.IO;

namespace mantis_tests 
{
    [TestFixture]
    public class AccountCreationTest : TestBase
    {
        [TestFixtureSetUp]
        public void setUpConfig()
        {
            app.FTP.BackUpFile("/config_inc.php");
            using (Stream localFile = File.Open("config_inc.php", FileMode.Open))
            {
                app.FTP.Upload("/config_inc.php", localFile);
            }
        }

        [Test]
        public void TestAccountRegistration()
        {
            AccountData account = new AccountData()
            {
                Name = "Test",
                Password = "1234",
                Email = "testuser@localhost.localdomain"
            };

            app.Registration.Register(account);
        }

        [TestFixtureTearDown]
        public void restoreConfig()
        {
            app.FTP.RestoreBackUpFile("/config_inc.php");
        }
    }
}
