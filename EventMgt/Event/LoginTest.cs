using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
namespace Event
{
    [TestFixture]
    class LoginTest
    {
        [Test]
        public void testWrongUsernameLogin()
        {
            Assert.AreEqual("User does not exist", User.login("user_wrong","pass"));
        }

        [Test]
        public void testWrongPasswordLogin()
        {
            Assert.AreEqual("Wrong password", User.login("user", "pass_wrong"));
        }

        [Test]
        public void testCorrectPasswordLogin()
        {
            Assert.AreEqual("Login successful", User.login("user", "password"));
        }
    }
}
