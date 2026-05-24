using OpenQA.Selenium;

namespace HerokuTests.SeleniumFramework
{
    public class CheckboxElement:BaseElement
    {
        public CheckboxElement(By locator, int timeOutSeconds = 10) : base(locator, timeOutSeconds) { }

        public bool IsChecked()
        {
            return Element.Selected;
        }
    }
}
