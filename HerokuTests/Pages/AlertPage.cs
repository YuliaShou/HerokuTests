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
        private By JSConfirmButtonLocator = By.XPath("//button[text()='Click for JS Confirm']");
        private By ResultLabelLocator = By.Id("result");
        private By JSPromptButtonLocator = By.XPath("//button[text()='Click for JS Prompt']");

        ButtonElement JSAlertButton => new ButtonElement(JSAlertButtonLocator);
        ButtonElement JSConfirmButton => new ButtonElement(JSConfirmButtonLocator);
        LabelElement ResultLabel => new LabelElement(ResultLabelLocator);
        ButtonElement JSPromptButton => new ButtonElement(JSPromptButtonLocator);

        public void ClickOkOnAllert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public void ClickJSAlertButton()
        {
            JSAlertButton.ClickElement();
        }

        public void ClickJSConfirmButton() 
        { 
            JSConfirmButton.ClickElement();
        }

        public void ClickCancelOnAlert() 
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        public string GetTextFromResultLabel()
        {
            return ResultLabel.GetText();
        }

        public void ClickJSPromptButton() 
        {
            JSPromptButton.ClickElement();
        }

        public void SendTextInAlert(string text)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys(text);
        }

    }
}
