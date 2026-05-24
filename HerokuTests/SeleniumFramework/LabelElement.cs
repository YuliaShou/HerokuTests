using OpenQA.Selenium;

namespace HerokuTests.SeleniumFramework
{
    public class LabelElement : BaseElement
    {
        public LabelElement(By locator, int timeOutSeconds = 10) : base(locator, timeOutSeconds) { }
    }
}
