using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Tests
{
    public class LoginTest:BaseTest
    {
        [Test]
        public void LoginUser()
        {
            Pages.HomePage.Login(
                TestData.TestData.Login.username,
                TestData.TestData.Login.password
                );

            //Assert
            Assert.IsTrue(Pages.HomePage.IsAccountOverviewPresented());
        }
    }
}
