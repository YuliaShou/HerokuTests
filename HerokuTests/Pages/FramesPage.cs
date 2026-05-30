using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;



namespace HerokuTests.Pages
{
    public class FramesPage
    {
        private const string FramePageLocator = "//a[text()='{0}']";

        ButtonElement FramePageButton(string frameButtonName) => new ButtonElement(By.XPath(Format(FramePageLocator, frameButtonName)));

        public void ClickFramePageButton(string frameName)
        {
            FramePageButton(frameName).ClickElement();
        }
    }
}
