using HerokuTests.Resources;
using HerokuTests.SeleniumFramework;
using HerokuTests.Utils;
using OpenQA.Selenium;
using static System.String;

namespace HerokuTests.Pages
{
    public class WelcomePage : BasePage
    {
        private By WelcomePageLabel1Locator = By.XPath("//h1");
        private By WelcomePageLabel2Locator = By.XPath("//h2");
        private const string PageButtonLocator = "//a[text()='{0}']";

        LabelElement WelcomeToTheInternetLabel => new LabelElement(WelcomePageLabel1Locator);
        LabelElement AvailableExamplesLabel => new LabelElement(WelcomePageLabel2Locator);
        ButtonElement PageButton(string pageName) => new ButtonElement(By.XPath(Format(PageButtonLocator, pageName)));

        public void OpenWelcomePage()
        {
            BrowserUtils.OpenPage(UrlConstants.WelcomePageUrl);
        }

        public string GetTextFromLabel1()
        {
            return WelcomeToTheInternetLabel.GetText();
        }
        
        public string GetTextFromLabel2()
        {
            return AvailableExamplesLabel.GetText();
        }

        public void ClickPageButton(string pageName)
        {
            PageButton(pageName).ClickElement();
        }
    }
}