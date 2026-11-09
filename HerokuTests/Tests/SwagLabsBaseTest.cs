using HerokuTests.Pages;
using HerokuTests.Saucedemo.Pages;
using HerokuTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Tests
{
    public class SwagLabsBaseTest
    {
        LoginPage loginPage => new LoginPage();
        [SetUp]
        public void Setup()
        {
            loginPage.OpenLoginPage();
        }

        [TearDown]
        public void TearDown()
        {
            BrowserUtils.Quit();
        }
    }
}
