using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;

namespace HerokuTests.Pages
{
    public class ContextMenuPage:BasePage
    {
        private By ContextMenuLocator = By.XPath("//h3");

        LabelElement ContextMenuLabel => new LabelElement(ContextMenuLocator);

        public string GetTextFromContextMenuLabel()
        {
            return ContextMenuLabel.GetText();
        }
    }
}
