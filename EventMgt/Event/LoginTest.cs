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
        public void testWrongLogin()
        {
            Assert.AreEqual("User does not exist", User.login("user_wrong","pass"));
        }
    }
}
