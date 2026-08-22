using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace HerokuTests.Pages.ModalWindows
{
    public class ModalWindowOnEntryAdPage : BasePage
    {
        private By ModalWindowOnEntryPageLocator = By.XPath("//div[@class='modal']//h3[text()='This is a modal window']");
        private By CloseButtonLocator = By.XPath("//p[text()='Close']");

        LabelElement ModalWindowOnEntryAdPageLabel => new LabelElement(ModalWindowOnEntryPageLocator);
        ButtonElement CloseButton => new ButtonElement(CloseButtonLocator);

        public bool IsModalWindowDisplayed()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(CloseButtonLocator));
            return ModalWindowOnEntryAdPageLabel.IsElementDisplayed();
        }

        public void ClickCloseButton()
        {
            CloseButton.ClickElement();
        }

        public bool IsModalWindowNotDisplayed()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(CloseButtonLocator));
            return ModalWindowOnEntryAdPageLabel.IsElementNotDisplayed();
        }
    }   
}
