using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.SeleniumFramework
{
    public class DropdownElement:BaseElement
    {
        public DropdownElement(By locator, int timeOutSeconds = 10) : base(locator, timeOutSeconds) { }

        public void SelectByText(string text)
        {
            SelectElement dropdown = new SelectElement(Element);
            dropdown.SelectByText(text);
        }

        public string GetTextFromOption()
        {
            SelectElement dropdown = new SelectElement(Element);
            var option = dropdown.SelectedOption;
            return option.Text;
        }
    }
}
