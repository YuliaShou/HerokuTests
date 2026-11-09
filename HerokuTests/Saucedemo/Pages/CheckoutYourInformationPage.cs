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
    public class CheckoutYourInformationPage:BasePage
    {
        private By CheckoutYourInformationLocator = By.XPath("//span[text()='Checkout: Your Information']");
        private By FirstNameFieldLocator = By.Id("first-name");
        private By LastNameFieldLocator = By.Id("last-name");
        private By ZipPostalCodeLocator = By.Id("postal-code");
        private By ContinueButtonLocator = By.Id("continue");

        LabelElement CheckoutYourInformationLabel => new LabelElement(CheckoutYourInformationLocator);
        FieldElement FirstNameField => new FieldElement(FirstNameFieldLocator);
        FieldElement LastNameField => new FieldElement(LastNameFieldLocator);
        FieldElement ZipPostalCodeField => new FieldElement(ZipPostalCodeLocator);
        ButtonElement ContinueButton => new ButtonElement(ContinueButtonLocator);

        public bool IsCheckoutYourInformationLabelDisplayed()
        {
            return CheckoutYourInformationLabel.IsElementDisplayed();
        }

        public void FillFirstNameField(string firstName)
        {
            FirstNameField.SetUpTextWithoutClear(firstName);
        }

        public void FillLastNameField(string lastName)
        {
            LastNameField.SetUpTextWithoutClear(lastName);
        }

        public void FillZipPostalCodeField(string zipPostalCode)
        {
            ZipPostalCodeField.SetUpTextWithoutClear(zipPostalCode);
        }

        public void ClickContinueButton()
        {
            ContinueButton.ClickElement();
        }
    }
}
