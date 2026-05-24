using HerokuTests.Pages;

namespace HerokuTests.Tests
{
    public class FormAuthenticationTest:BaseTest
    {
        FormAuthenticationPage formAuthenticationPage = new FormAuthenticationPage();
        WelcomePage welcomePage = new WelcomePage();

        [TestCase("tomsmith", "SuperSecretPassword!", "You logged into a secure area!")]
        [TestCase("User", "Password", "Your username is invalid!")]
        [TestCase("Yulia", "qweqwe", "Your username is invalid!")]
        public void FillRightFormAuthentication(string userName, string password, string message)
        {
            welcomePage.ClickPageButton("Form Authentication");
            string textFromFormAuthenticationLabel = formAuthenticationPage.GetTextFromFormAuthenticationLabel();
            string expectedText = "Login Page";
            Assert.AreEqual(expectedText, textFromFormAuthenticationLabel, "Text are not Equal");
            formAuthenticationPage.FillLoginField(userName);
            formAuthenticationPage.FillPasswordField(password);
            formAuthenticationPage.ClickLoginButton();
            string textFromErrorLabel = formAuthenticationPage.GetTextFromErrorLabel();
            bool isErrorContains = textFromErrorLabel.Contains(message);
            Assert.IsTrue(isErrorContains, "Error message is right");
        }
    }
}
