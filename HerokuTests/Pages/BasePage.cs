using HerokuTests.Utils;
using OpenQA.Selenium;

namespace HerokuTests.Pages
{
    public abstract class BasePage
    {
        public IWebDriver driver => BrowserUtils.Driver;
    }
}