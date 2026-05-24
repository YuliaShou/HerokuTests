using OpenQA.Selenium;

namespace HerokuTests.SeleniumFramework
{
    public class ButtonElement : BaseElement
    {
        public ButtonElement(By locator, int timeOutSeconds = 10) : base(locator, timeOutSeconds) { }

        public void ClickIfEnabled()
        {
            if (IsEnabled())
            {
                ClickElement();
            }
        }
    }
}
