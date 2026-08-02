using HerokuTests.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;

namespace HerokuTests.SeleniumFramework
{
    public class BaseElement
    {
        protected IWebDriver Driver = BrowserUtils.Driver;
        protected By Locator;
        protected WebDriverWait Wait;

        public BaseElement(By locator, int timeOutSeconds = 10)
        {
            Locator = locator;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeOutSeconds));
        }

        public IWebElement Element => Wait.Until(driver => driver.FindElement(Locator));
        public IList<IWebElement> Elements => Wait.Until(driver => driver.FindElements(Locator));
        public bool IsEnabled()
        {
            return Element.Enabled;
        }

        public bool IsElementDisplayed()
        {
            return Element.Displayed;
        }

        public bool IsElementNotDisplayed()
        {
            int EC = Elements.Count();
            if (EC == 0) { return true; }
            else return false;
        }

        public void ClickElement()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(Locator)).Click();
        }

        public void SetUpTextWithClear(string text)
        {
            Element.Clear();
            Element.SendKeys(text);
        }

        public void SetUpTextWithoutClear(string text)
        {
            Element.SendKeys(text);
        }

        public string GetText()
        {
            return Element.Text;
        }

        public string? GetAttributeValue(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }

        public int GetElementsCount()
        {
            return Elements.Count;
        }

        public void MoveToElement()
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(Element).Perform();
        }

        public void RightClick()
        {
            Actions actions = new Actions(Driver);
            actions.ContextClick(Element).Perform();
        }
    }
}

