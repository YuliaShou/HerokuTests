using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using static System.String;

namespace HerokuTests.Pages
{
    public class FileDownloadPage:BasePage
    {
        private By FileDownloadLabelLocator = By.XPath("//h3");
        private const string FileOnPageLocator = "//a[text()='{0}.{1}']";

        LabelElement FileDownloadLabel => new LabelElement(FileDownloadLabelLocator);
        LabelElement FileOnPageLabel(string fileName, string fileFormat) => new LabelElement (By.XPath
            (Format(FileOnPageLocator, fileName, fileFormat)));

        public string GetTextFromFileDownloadLabel()
        {
            return FileDownloadLabel.GetText();
        }

        public bool IsFileOnPageExist(string fileName, string fileFormat)
        {
            return FileOnPageLabel(fileName, fileFormat).IsElementDisplayed();
        }

        public void ClickOnFileOnPageLabel(string fileName, string fileFormat)
        {
            FileOnPageLabel(fileName, fileFormat).ClickElement();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("arguments[0].click();", FileOnPageLabel(fileName, fileFormat));
        }
    }
}
