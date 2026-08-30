using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Pages
{
    public class MultipleWindows : BasePage
    {
        private By ClickHereButtonLocator = By.XPath("//a[contains(text(), 'Click Here')]");
        private By NewWindowLocator = By.XPath("//h3[text()='New Window']");

        ButtonElement ClickHereButton => new ButtonElement(ClickHereButtonLocator);
        LabelElement NewWindowLabel => new LabelElement(NewWindowLocator);

        public void ClickClickHere() 
        {
            ClickHereButton.ClickElement();
        }

        public bool IsNewWindowLabelExist()
        {
            return NewWindowLabel.IsElementDisplayed();
        }
    }
}
