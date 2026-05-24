using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;

namespace HerokuTests.Pages
{
    public class ABTestingPage : BasePage
    {
        private By ABControlLabelLocator = By.XPath("//h3");

        LabelElement ABTestLabel => new LabelElement(ABControlLabelLocator);

        public string GetTextFromABTestLabel()
        {
            return ABTestLabel.GetText();
        }
    }
}
