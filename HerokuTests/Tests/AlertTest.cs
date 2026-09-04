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
            alertPage.ClickOkOnAllert();
            Assert.AreEqual(alertPage.GetTextFromResultLabel(), "You successfully clicked an alert", "Texts are not equal");
            alertPage.ClickJSConfirmButton();
            alertPage.ClickCancelOnAlert();
            alertPage.GetTextFromResultLabel();
            string textFromResultLabel= alertPage.GetTextFromResultLabel();
            Assert.AreEqual(textFromResultLabel, "You clicked: Cancel", "Texts are not equal");
            alertPage.ClickJSConfirmButton();
            alertPage.ClickOkOnAllert();
            Assert.AreEqual(alertPage.GetTextFromResultLabel(), "You clicked: Ok", "Texts are not equal");
            alertPage.ClickJSPromptButton();
            alertPage.SendTextInAlert("Test");
            alertPage.ClickOkOnAllert();
            Assert.AreEqual(alertPage.GetTextFromResultLabel(), "You entered: Test", "Texts are not equal");
        }
    }
}
