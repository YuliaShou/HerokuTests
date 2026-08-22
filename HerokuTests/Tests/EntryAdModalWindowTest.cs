using HerokuTests.Pages;
using HerokuTests.Pages.ModalWindows;
using HerokuTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Tests
{
     public class EntryAdModalWindowTest:BaseTest
    {
        WelcomePage welcomePage = new WelcomePage();
        EntryAdPage entryAdPage = new EntryAdPage();
        ModalWindowOnEntryAdPage modalWindowOnEntryAdPage = new ModalWindowOnEntryAdPage();

        [Test]
        public void ModalWindowOnEntryAdPage()
        {
            welcomePage.ClickPageButton("Entry Ad");
            string textFromEntryAdPageLabel = entryAdPage.GetTextFromEntryAdPageLabel();
            Assert.AreEqual("Entry Ad", textFromEntryAdPageLabel, "Texts are not equal");
            bool isModalWindowDisplayed = modalWindowOnEntryAdPage.IsModalWindowDisplayed();
            Assert.IsTrue(isModalWindowDisplayed, "Modal Window is not displayed");
            modalWindowOnEntryAdPage.ClickCloseButton();
            Thread.Sleep(2000);
            BrowserUtils.RefreshPage();
            bool isModalWindowDisplayedAfterRefresh = modalWindowOnEntryAdPage.IsModalWindowDisplayed();
            Assert.IsTrue(isModalWindowDisplayedAfterRefresh, "Modal Window is not displayed");
        }
    }
}
