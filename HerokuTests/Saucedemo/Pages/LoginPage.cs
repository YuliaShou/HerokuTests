using HerokuTests.Pages;
using HerokuTests.Resources;
using HerokuTests.SeleniumFramework;
using HerokuTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Saucedemo.Pages
{
    public class LoginPage:BasePage
    {
        private By LoginPageLabelLocator = By.XPath("//div[text()='Swag Labs']");
        private By LoginFieldLocator = By.Id("user-name");
        private By PasswordFieldLocator = By.Id("password");
        private By LoginButtonLocator = By.Id("login-button");

        LabelElement LoginPageLabelElement => new LabelElement(LoginPageLabelLocator);
        FieldElement LoginFieldElement => new FieldElement(LoginFieldLocator);
        FieldElement PasswordFieldElement => new FieldElement(PasswordFieldLocator);
        ButtonElement LoginButtonElement => new ButtonElement(LoginButtonLocator);


        public bool IsLoginPageLabelDisplayed()
        {
            return LoginPageLabelElement.IsElementDisplayed();
        }

        public void FillLoginField(string login)
        {
            LoginFieldElement.SetUpTextWithoutClear(login);
        }

        public void FillPasswordField(string password)
        {
            PasswordFieldElement.SetUpTextWithoutClear(password);
        }

        public void ClickLoginButton()
        {
            LoginButtonElement.ClickElement();
        }

        public void OpenLoginPage()
        {
            BrowserUtils.OpenPage(UrlConstants.SwagLabsPageUrl);
        }
    }
}
