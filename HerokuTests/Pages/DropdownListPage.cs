using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Pages
{
    public class DropdownListPage:BasePage
    {
        private By DropdownListPageLocator = By.XPath("//h3");
        private By DropdownLocator = By.Id("dropdown");

        LabelElement DropdownListPageLabel => new LabelElement(DropdownListPageLocator);
        DropdownElement Dropdown => new DropdownElement(DropdownLocator);

        public string GetTextFromDropdownListLabel()
        {
            return DropdownListPageLabel.GetText();
        }

        public void SelectOption(string option)
        {
            Dropdown.SelectByText(option);
        }

        public string GetTextFromSelectedOption() 
        { 
            return Dropdown.GetTextFromOption();
        }

    }
}
