using HerokuTests.Pages;
using HerokuTests.Pages.ModalWindows;
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
            Thread.Sleep(5000);
            bool isModalWindowDisplayed = modalWindowOnEntryAdPage.IsModalWindowDisplayed();
            Assert.IsTrue(isModalWindowDisplayed, "Modal Window is not displayed");
        }
    }
}
