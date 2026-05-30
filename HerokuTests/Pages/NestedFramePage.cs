using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Pages
{
    public class NestedFramePage
    {
        public By LeftFrameLocator = By.XPath("//body[contains(text(), 'LEFT')]");
        public By LeftTopFrameLocator = By.XPath("//frame[@name='frame-left']");

        LabelElement LeftFrameElement => new LabelElement(LeftFrameLocator);
        FrameElement TopLeftFrameElement => new FrameElement(LeftTopFrameLocator);

        public bool IsLeftFrameExist()
        {
            TopLeftFrameElement.SwitchTo();
            bool state = LeftFrameElement.IsElementDisplayed();
            return state;
        }
    }
}
