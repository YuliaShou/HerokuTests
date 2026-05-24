using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using static System.String;

namespace HerokuTests.Pages
{
    public class JQueryUIMenusPage:BasePage
    {
        private By HoverDropdownLocator = By.XPath("//a[text()='Enabled']");
        private By DownloadOptionLocator = By.XPath("//a[text()='Downloads']");
        private const string FileExtentionsLocator = ("//a[text()='{0}']");

        LabelElement EnabledLabelDropdown => new LabelElement(HoverDropdownLocator);
        LabelElement DownloadOption => new LabelElement(DownloadOptionLocator);
        ButtonElement FileExtentionsButton(string fileExtension) => new ButtonElement(By.XPath(Format(FileExtentionsLocator, fileExtension)));

        public void MoveToDropdownIfExist() 
        {
            if (EnabledLabelDropdown.IsElementDisplayed())
            {
                EnabledLabelDropdown.MoveToElement();
                Thread.Sleep(2000);
            }
            else 
            {
                throw new Exception("Dropdown isn't exist");
            }
        }

        public void MoveToDownloadOption()
        { 
            DownloadOption.MoveToElement();
            Thread.Sleep(2000);
        }

        public void ClickFileExtentionsButton(string fileExtension)
        {
            FileExtentionsButton(fileExtension).ClickElement();
            Thread.Sleep(2000);
        }
    }
}
