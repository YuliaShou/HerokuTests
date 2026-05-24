using OpenQA.Selenium;

namespace HerokuTests.SeleniumFramework
{
    public class FieldElement : BaseElement 
    {
        public FieldElement(By locator, int timeOutSeconds = 10) : base(locator, timeOutSeconds) { }
    }
}
