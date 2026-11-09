using HerokuTests.Pages;
using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Saucedemo.Pages
{
    public class CheckoutCompletePage:BasePage
    {
        private By CheckoutCompleteLabelLocator = By.XPath("//span[text()='Checkout: Complete!']");
        private By SuccessMessageLocator = By.XPath("//h2[text()='Thank you for your order!']");

        LabelElement CheckoutCompleteLabel => new LabelElement(CheckoutCompleteLabelLocator);
        LabelElement SuccessMessage => new LabelElement(SuccessMessageLocator);

        public bool IsCheckoutCompleteLabelDisplayed()
        {
            return CheckoutCompleteLabel.IsElementDisplayed();
        }

        public bool IsSuccessMessageDisplayed()
        {
            return SuccessMessage.IsElementDisplayed();
        }
    }
}
