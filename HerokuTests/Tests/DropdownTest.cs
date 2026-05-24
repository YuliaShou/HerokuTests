using HerokuTests.Pages;
using HerokuTests.Utils;
using OpenQA.Selenium.DevTools.V140.IndexedDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Tests
{
    public class DropdownTest : BaseTest
    {
        DropdownListPage dropdownListPage = new DropdownListPage();
        WelcomePage welcomePage = new WelcomePage();
        JQueryUIMenusPage jQueryUIMenusPage = new JQueryUIMenusPage();

        [Test]

        public void ExpandDropdownTest()
        {
            welcomePage.ClickPageButton("Dropdown");
            string textFromDropdownListLabel = dropdownListPage.GetTextFromDropdownListLabel();
            string expectedText = "Dropdown List";
            Assert.AreEqual(expectedText, textFromDropdownListLabel, "Texts are not equal");
            string textFromSelectedOption = dropdownListPage.GetTextFromSelectedOption();
            string expectedTextFromDefaultOption = "Please select an option";
            Assert.AreEqual(expectedTextFromDefaultOption, textFromSelectedOption, "Texts are not equal");
            dropdownListPage.SelectOption("Option 1");
            string textFromSelectedOption1 = dropdownListPage.GetTextFromSelectedOption();
            Assert.AreEqual("Option 1", textFromSelectedOption1, "Texts are not equal");
            dropdownListPage.SelectOption("Option 2");
            string textFromSelectedOption2 = dropdownListPage.GetTextFromSelectedOption();
            Assert.AreEqual("Option 2", textFromSelectedOption2, "Texts are not equal");
            BrowserUtils.RefreshPage();
            string refreshTextFromSelectedOption = dropdownListPage.GetTextFromSelectedOption();
            Assert.AreEqual(expectedTextFromDefaultOption, refreshTextFromSelectedOption, "Texts are not equal");
            BrowserUtils.GoToBack();
            string textWelcomeToTheInternet = welcomePage.GetTextFromLabel1();
            string expectedTextAfterBack = "Welcome to the-internet";
            Assert.AreEqual(expectedTextAfterBack, textWelcomeToTheInternet, "Texts are not equal");
        }

        [TestCase("PDF", "menu.pdf")]
        [TestCase("CSV", "menu.csv")]
        [TestCase("Excel", "menu.xls")]

        public void HoverDropdownTest(string fileExtension, string fileName)
        {
            welcomePage.ClickPageButton("JQuery UI Menus");
            jQueryUIMenusPage.MoveToDropdownIfExist();
            jQueryUIMenusPage.MoveToDownloadOption();
            jQueryUIMenusPage.ClickFileExtentionsButton(fileExtension);
            Assert.IsTrue(FileUtils.WaitForFile(fileName, TimeSpan.FromSeconds(10)),
                "File not exist");
            FileUtils.DeleteFile(fileName);
            Assert.IsFalse(FileUtils.WaitForFile(fileName, TimeSpan.FromSeconds(5)), "File is not Deleted");
        }
    }
}