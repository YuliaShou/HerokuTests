using HerokuTests.Pages;

namespace HerokuTests.Tests
{
    public class AddRemoveElementsTest:BaseTest
    {
        AddRemoveElementsPage addRemoveElementsPage = new AddRemoveElementsPage();
        WelcomePage welcomePage = new WelcomePage();

        [Test]
        public void CheckButtonCount()
        {
            welcomePage.ClickPageButton("Add/Remove Elements");
            string textFromAddRemoveEleemntLabel = addRemoveElementsPage.GetTextFromAddRemoveElementsLabel();
            string expectedText = "Add/Remove Elements";
            Assert.AreEqual(expectedText, textFromAddRemoveEleemntLabel, "Text are not Equal");
            addRemoveElementsPage.ClickOnAddElementButton();
            addRemoveElementsPage.ClickOnAddElementButton();
            int numberOfButtons = addRemoveElementsPage.GetDeleteButtonCount();
            Assert.AreEqual(2, numberOfButtons, "number is wrong");
        }
    }
}
