using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;

namespace HerokuTests.Pages.ModalWindows
{
    public class ModalWindowOnEntryAdPage
    {
        private By ModalWindowOnEntryPageLocator = By.XPath("//div[@class='modal']//h3[text()='This is a modal window']");

        LabelElement ModalWindowOnEntryPageLabel => new LabelElement(ModalWindowOnEntryPageLocator);

        public bool IsModalWindowDisplayed()
        {
            return ModalWindowOnEntryPageLabel.IsElementDisplayed();
        }
    }   
}
