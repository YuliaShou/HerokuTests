using HerokuTests.Saucedemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Tests
{
    public class LoginSwagLabsTest:SwagLabsBaseTest
    {
        LoginPage loginPage => new LoginPage();
        ProductsPage productsPage => new ProductsPage();
        YourCartPage yourCartPage => new YourCartPage();
        CheckoutYourInformationPage checkoutYourInformationPage => new CheckoutYourInformationPage();
        CheckoutOverviewPage checkoutOverviewPage => new CheckoutOverviewPage();
        CheckoutCompletePage checkoutCompletePage => new CheckoutCompletePage();

        [Test]
        public void LoginPageTest()
        {
            Assert.IsTrue(loginPage.IsLoginPageLabelDisplayed(), "The LoginPageLabel is not Displayed");
            loginPage.FillLoginField("standard_user");
            loginPage.FillPasswordField("secret_sauce");
            loginPage.ClickLoginButton();
            Assert.IsTrue(productsPage.IsProductLabelDisplayed(), "The ProductLabel is not Displayed");
            productsPage.AddItemToCart("Sauce Labs Backpack");
            productsPage.AddItemToCart("Sauce Labs Onesie");
            string cartCount = productsPage.GetTextFromCartCountLabel();
            Assert.AreEqual("2", cartCount, $"Item's Count is not Equal. Expected:2, but was:{cartCount}");
            productsPage.ClikCartButton();
            Assert.IsTrue(yourCartPage.IsYourCartLabelDisplayed(), "The YourCartLabel is not Displayed");

            Assert.Multiple(() =>
            {
                Assert.IsTrue(yourCartPage.IsItemNameLabelDisplayed("Sauce Labs Backpack"), "Sauce Labs Backpack is not Displayed");
                Assert.IsTrue(yourCartPage.IsItemNameLabelDisplayed("Sauce Labs1 Onesie"), "Sauce Labs Onesie1 is not Displayed");
                Assert.IsTrue(yourCartPage.IsItemNameLabelDisplayed("Sauce Labs Onesie"), "Sauce Labs Onesie is not Displayed");
                Assert.IsTrue(yourCartPage.IsItemNameLabelDisplayed("Sauce Labs2 Backpack"), "Sauce Labs Backpack2 is not Displayed");
            });
            yourCartPage.ClickCheckoutButton();
            Assert.IsTrue(checkoutYourInformationPage.IsCheckoutYourInformationLabelDisplayed(), "YourInformationLabel is not Displayed");
            checkoutYourInformationPage.FillFirstNameField("Yulia");          
            checkoutYourInformationPage.FillLastNameField("Chtchourko");           
            checkoutYourInformationPage.FillZipPostalCodeField("12345");
            checkoutYourInformationPage.ClickContinueButton();
            Assert.IsTrue(checkoutOverviewPage.IsCheckoutOverviewLabelDisplayed(),"The CheckoutOverviewPageLabel is not Displayed");
            Assert.Multiple(() =>
            {
                Assert.IsTrue(checkoutOverviewPage.IsItemNameLabelElementDisplayed("Sauce Labs Backpack"), "Sauce Labs Backpack is not displayed");
                Assert.IsTrue(checkoutOverviewPage.IsItemNameLabelElementDisplayed("Sauce Labs Onesie"), "Sauce Labs Onesie is not displayed");
            });
            checkoutOverviewPage.ClickFinishButton();
            Assert.IsTrue(checkoutCompletePage.IsCheckoutCompleteLabelDisplayed(), "The CheckoutCompleteLabel is not Displayed");
            Assert.IsTrue(checkoutCompletePage.IsSuccessMessageDisplayed(), "The Success Message is not Displayed");
            Thread.Sleep(5000);
        }
    }
}
