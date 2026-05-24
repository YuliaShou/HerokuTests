using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;

namespace HerokuTests.Pages
{
    public class FormAuthenticationPage:BasePage
    {
        private By FormAuthenticationLocator = By.XPath("//h2");
        private By LoginFieldLocator = By.Id("username");
        private By PasswordFieldLocator = By.Id("password");
        private By LoginButtonLocator = By.ClassName("radius");
        private By ErrorLocator = By.XPath("//div[@id='flash']");

        LabelElement FormAuthenticationLabel => new LabelElement(FormAuthenticationLocator);
        FieldElement LoginField => new FieldElement(LoginFieldLocator);
        FieldElement PasswordField => new FieldElement(PasswordFieldLocator);
        ButtonElement LoginButton => new ButtonElement(LoginButtonLocator);
        LabelElement ErrorLabel => new LabelElement(ErrorLocator);

        public string GetTextFromFormAuthenticationLabel()
        {
            return FormAuthenticationLabel.GetText();
        }

        public void FillLoginField(string login)
        {
            LoginField.SetUpTextWithoutClear(login);
        }

        public void FillPasswordField(string password)
        {
            PasswordField.SetUpTextWithoutClear(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.ClickElement();
        }

        public string GetTextFromErrorLabel() 
        {
            return ErrorLabel.GetText();
        }
    }
}
