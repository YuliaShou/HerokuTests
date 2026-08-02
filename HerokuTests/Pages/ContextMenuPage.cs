using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;

namespace HerokuTests.Pages
{
    public class ContextMenuPage:BasePage
    {
        private By ContextMenuLocator = By.XPath("//h3");
        private By AreaForContextMenuLocator = By.Id("hot-spot");

        LabelElement ContextMenuLabel => new LabelElement(ContextMenuLocator);
        LabelElement AreaForContextMenuLabel => new LabelElement(AreaForContextMenuLocator);

        public string GetTextFromContextMenuLabel()
        {
            return ContextMenuLabel.GetText();
        }

        public void RightClickAreaForContextMenu()
        {
            AreaForContextMenuLabel.RightClick();
        }

        public void ClickOkOnAllert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
