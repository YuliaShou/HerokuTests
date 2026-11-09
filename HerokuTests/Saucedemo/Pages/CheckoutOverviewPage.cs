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
    public class CheckoutOverviewPage : BasePage
    {
        private By CheckoutOverviewLabelLocator = By.XPath("//span[text()='Checkout: Overview']");
        private const string ItemNameLocator = "//div[text()='{0}']";
        private By FinishButtonLocator = By.XPath("//button[text()='Finish']");

        LabelElement CheckoutOverviewPageLabel => new LabelElement(CheckoutOverviewLabelLocator);
        LabelElement ItemNameLabelElement(string itemName) => new LabelElement(By.XPath(Format(ItemNameLocator, itemName)));
        ButtonElement FinishButton => new ButtonElement(FinishButtonLocator);

        public bool IsCheckoutOverviewLabelDisplayed() 
        {
            return CheckoutOverviewPageLabel.IsElementDisplayed();
        }

        public bool IsItemNameLabelElementDisplayed(string itemName)
        {
            return ItemNameLabelElement(itemName).IsElementDisplayed();
        }

        public void ClickFinishButton()
        {
            FinishButton.ClickElement();
        }
    }
}
