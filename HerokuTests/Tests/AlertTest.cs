using HerokuTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Tests
{
    public class AlertTest:BaseTest
    {
        AlertPage alertPage = new AlertPage();
        WelcomePage welcomePage = new WelcomePage();

        [Test]
        public void SimpleAlertTest()
        {
            welcomePage.ClickPageButton("JavaScript Alerts");
            alertPage.ClickJSAlertButton();
            Thread.Sleep(3000);
            alertPage.ClickJSAllert();
            Thread.Sleep(3000);
        }
    }
}
