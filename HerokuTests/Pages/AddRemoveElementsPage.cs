using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;

namespace HerokuTests.Pages
{
    public class AddRemoveElementsPage:BasePage
    {
        private By AddRemoveElementsLocator = By.XPath("//h3");
        private By AddElementLocator = By.XPath("//button[text()='Add Element']");
        private By DeleteElementLocator = By.XPath("//button[text()='Delete']");

        LabelElement AddRemoveElementsLabel => new LabelElement(AddRemoveElementsLocator);
        ButtonElement AddElementButton => new ButtonElement(AddElementLocator);
        ButtonElement DeleteButton => new ButtonElement(DeleteElementLocator);

        public string GetTextFromAddRemoveElementsLabel()
        {
            return AddRemoveElementsLabel.GetText();
        }

        public void ClickOnAddElementButton()
        {
            AddElementButton.ClickElement();
            Thread.Sleep(3000);
        }

        public int GetDeleteButtonCount()
        {
            return DeleteButton.GetElementsCount();
        }
    }
}
