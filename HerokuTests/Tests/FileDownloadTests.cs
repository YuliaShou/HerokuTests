using HerokuTests.Pages;
using HerokuTests.Utils;

namespace HerokuTests.Tests
{
    public class FileDownloadTests:BaseTest
    {
        FileDownloadPage fileDownloadPage = new FileDownloadPage();
        WelcomePage welcomePage = new WelcomePage();

        [Test]
        public void CheckFileExist()
        {
            welcomePage.ClickPageButton("File Download");
            string textFromFileDownloadLabel = fileDownloadPage.GetTextFromFileDownloadLabel();
            string expectedText = "File Downloader";
            Assert.AreEqual(expectedText, textFromFileDownloadLabel, "Text are not equal");
            Assert.IsTrue(fileDownloadPage.IsFileOnPageExist("bb", "txt"), "File is not exist");
        }

        [Test]
        public void CheckDownloadFileExist() 
        {
            welcomePage.ClickPageButton("File Download");
            string textFromFileDownloadLabel = fileDownloadPage.GetTextFromFileDownloadLabel();
            string expectedText = "File Downloader";
            Assert.AreEqual(expectedText, textFromFileDownloadLabel, "Text are not equal");
            Assert.IsTrue(fileDownloadPage.IsFileOnPageExist("Test", "txt"), "File is not exist");
            fileDownloadPage.ClickOnFileOnPageLabel("Test", "txt");
            bool isFileExist = FileUtils.WaitForFile("Test.txt", TimeSpan.FromSeconds(30));
            Assert.IsTrue(isFileExist, "File isn't downloaded");
            FileUtils.DeleteFile("Test.txt");
            bool isFileNotExist = FileUtils.WaitForFile("Test.txt", TimeSpan.FromSeconds(5));
            Assert.IsFalse(isFileNotExist, "File isn't deleted");
        }
    }
}
