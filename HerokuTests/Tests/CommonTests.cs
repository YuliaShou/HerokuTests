using HerokuTests.Pages;

namespace HerokuTests.Tests
{
    public class CommonTests:BaseTest
    {
        WelcomePage welcomePage = new WelcomePage();
        ABTestingPage abTestingPage = new ABTestingPage();
        ContextMenuPage contextMenuPage = new ContextMenuPage(); 

        [Test]
        public void ClickABTestingTest()
        {
            welcomePage.ClickPageButton("A/B Testing");
            string textFromABTestingPage = abTestingPage.GetTextFromABTestLabel();
            string expectedText = "A/B Test Control";
            Assert.AreEqual(expectedText, textFromABTestingPage, "Texts are not equal");
        }

        [Test]
        public void OpenWrelcomePageVerifying()
        {
            string textWelcomeToTheInternet = welcomePage.GetTextFromLabel1();
            string expectedText = "Welcome to the-internet";
            Assert.AreEqual(expectedText, textWelcomeToTheInternet, "Texts are not equal");
            string textAvailableExamples = welcomePage.GetTextFromLabel2();
            string expectedText2 = "Available Examples";
            Assert.AreEqual(expectedText2, textAvailableExamples, "Text are not equal");
        }

        [Test]
        public void ClickContextMenuTest()
        {
            welcomePage.ClickPageButton("Context Menu");
            string textFromContextMenuPage = contextMenuPage.GetTextFromContextMenuLabel();
            string expectedText = "Context Menu";
            Assert.AreEqual(expectedText, textFromContextMenuPage, "Texts are not equal");
            contextMenuPage.RightClickAreaForContextMenu();
            Thread.Sleep(5000);
            contextMenuPage.ClickOkOnAllert();
            Thread.Sleep(5000);
        }
    }
}