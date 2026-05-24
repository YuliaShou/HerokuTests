using HerokuTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Tests
{
    public class CheckboxesTest:BaseTest
    {
        CheckboxesPage checkboxesPage = new CheckboxesPage();
        WelcomePage welcomePage = new WelcomePage();

        [Test]
        public void CheckCheckboxState()
        {
            welcomePage.ClickPageButton("Checkboxes");
            string textFromCheckboxLabel = checkboxesPage.GetTextFromCheckboxLabel();
            string expectedText = "Checkboxes";
            Assert.AreEqual(expectedText, textFromCheckboxLabel, "Text are not equal");
            bool stateOfCheckbox1 = checkboxesPage.GetStateOfCheckbox(1);
            Assert.IsFalse(stateOfCheckbox1,"State is not false");
            bool stateOfCheckbox2 = checkboxesPage.GetStateOfCheckbox(2);
            Assert.IsTrue(stateOfCheckbox2, "State is not true");
            checkboxesPage.CheckCheckbox(1);
            stateOfCheckbox1 = checkboxesPage.GetStateOfCheckbox(1);
            Assert.IsTrue(stateOfCheckbox1, "State is not true");
            stateOfCheckbox2 = checkboxesPage.GetStateOfCheckbox(2);
            Assert.IsTrue(stateOfCheckbox2, "State is not true");
            checkboxesPage.CheckCheckbox(1);
            checkboxesPage.CheckCheckbox(2);
            stateOfCheckbox1 = checkboxesPage.GetStateOfCheckbox(1);
            stateOfCheckbox2 = checkboxesPage.GetStateOfCheckbox(2);
            Assert.IsFalse(stateOfCheckbox1, "State is not false");
            Assert.IsFalse(stateOfCheckbox2, "State is not false");
        }

        [Test]
        public void UncheckCheckbox()
        {
            welcomePage.ClickPageButton("Checkboxes");
            string textFromCheckboxLabel = checkboxesPage.GetTextFromCheckboxLabel();
            string expectedText = "Checkboxes";
            Assert.AreEqual(expectedText, textFromCheckboxLabel, "Text are not equal");
            bool stateOfCheckbox2 = checkboxesPage.GetStateOfCheckbox(2);
            checkboxesPage.UnCheckCheckboxIfChecked(2,stateOfCheckbox2);
            stateOfCheckbox2 = checkboxesPage.GetStateOfCheckbox(2);
            Assert.IsFalse(stateOfCheckbox2, "State is not false");
            bool stateOfCheckbox1 = checkboxesPage.GetStateOfCheckbox(1);
            checkboxesPage.UnCheckCheckboxIfChecked(1, stateOfCheckbox1);
            stateOfCheckbox1 = checkboxesPage.GetStateOfCheckbox(1);
            Assert.IsFalse(stateOfCheckbox1, "State is not false");
        }
    }
}
