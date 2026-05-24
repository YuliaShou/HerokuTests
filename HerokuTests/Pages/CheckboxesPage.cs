using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using static System.String;

namespace HerokuTests.Pages
{
    public class CheckboxesPage:BasePage
    {
        private By CheckboxPageLocator = By.XPath("//h3");
        private const string CheckboxLocator = "//input[@type='checkbox'][{0}]";

        LabelElement CheckboxPageLabel => new LabelElement(CheckboxPageLocator);
        CheckboxElement CheckboxElement(int checkboxNumber) => new CheckboxElement(By.XPath(Format(CheckboxLocator, checkboxNumber)));

        public string GetTextFromCheckboxLabel()
        {
            return CheckboxPageLabel.GetText();
        }

        public bool GetStateOfCheckbox(int checkboxNumber)
        {
            return CheckboxElement(checkboxNumber).IsChecked();
        }

        public void CheckCheckbox(int checkboxNumber) 
        {
            CheckboxElement(checkboxNumber).ClickElement();
        }

        public void UnCheckCheckboxIfChecked(int checkboxNumber, bool stateOfCheckbox)
        {
            if (stateOfCheckbox)
            {
                CheckCheckbox(checkboxNumber);
            }
        }
    }
}
