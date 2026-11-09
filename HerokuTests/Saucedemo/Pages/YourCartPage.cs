using HerokuTests.Pages;
using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace HerokuTests.Saucedemo.Pages
{
    public class YourCartPage:BasePage
    {
        private By YourCartLabelLocator = By.XPath("//span[text()='Your Cart']");
        private const string ItemNameLocator = ("//div[text()='{0}']");
        private By CheckoutButtonLocator = By.XPath("//button[text()='Checkout']");

        LabelElement YourCartLabel => new LabelElement(YourCartLabelLocator);
        LabelElement ItemNameLabel(string itemName) => new LabelElement(By.XPath(Format(ItemNameLocator, itemName)));
        ButtonElement CheckoutButton => new ButtonElement(CheckoutButtonLocator);

        public bool IsYourCartLabelDisplayed()
        {
            return YourCartLabel.IsElementDisplayed();
        }

        public bool IsItemNameLabelDisplayed(string itemName)
        {
            try
            {
                ItemNameLabel(itemName).IsElementDisplayed();
                return true;
            }
            catch
            { 
                return false;
            }
        }

        public void ClickCheckoutButton()
        {
            CheckoutButton.ClickElement();
        }
    }
}
