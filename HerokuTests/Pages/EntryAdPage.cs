using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;

namespace HerokuTests.Pages
{
    public class EntryAdPage:BasePage
    {
        private By EntryAdPageLocator = By.XPath("//h3");

        LabelElement EntryAdPageLabel => new LabelElement(EntryAdPageLocator);

        public string GetTextFromEntryAdPageLabel()
        {
            return EntryAdPageLabel.GetText();
        }
    }
}
