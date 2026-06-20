using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Pages
{
    public class AlertPage:BasePage
    {
        private By JSAlertButtonLocator = By.XPath("//button[text()='Click for JS Alert']");

        ButtonElement JSAlertButton => new ButtonElement(JSAlertButtonLocator);


        public void ClickJSAllert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public void ClickJSAlertButton()
        {
            JSAlertButton.ClickElement();
        }
    }
}
