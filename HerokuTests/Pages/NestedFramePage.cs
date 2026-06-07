using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Pages
{
    public class NestedFramePage:BasePage
    {
        public By LeftFrameLocator = By.XPath("//body[contains(text(), 'LEFT')]");
        public By MiddleFrameLocator = By.XPath("//div[contains(text(), 'MIDDLE')]");
        public By RightFrameLocator = By.XPath("//body[contains(text(), 'RIGHT')]");
        public By BottomFrameLocator = By.XPath("//body[contains(text(), 'BOTTOM')]");

        LabelElement LeftFrameElement => new LabelElement(LeftFrameLocator);
        LabelElement MiddleFrameElement => new LabelElement(MiddleFrameLocator);
        LabelElement RightFrameElement => new LabelElement(RightFrameLocator);
        LabelElement BottomFrameElement => new LabelElement(BottomFrameLocator);

        public bool IsLeftFrameExist()
        {
            driver.SwitchTo().Frame("frame-top");
            driver.SwitchTo().Frame("frame-left");
            var state = LeftFrameElement.IsElementDisplayed();
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().DefaultContent();
            return state;
        }

        public bool IsMiddleFrameExist()
        {
            driver.SwitchTo().Frame("frame-top");
            driver.SwitchTo().Frame("frame-middle");
            var state = MiddleFrameElement.IsElementDisplayed();
            //driver.SwitchTo().ParentFrame(); если нам ничего не нужно делать в родительском фрейме, можно сразу переключаться на Default Content
            driver.SwitchTo().DefaultContent();
            return state;
        }

        public bool IsRightFrameExist()
        {
            driver.SwitchTo().Frame("frame-top");
            driver.SwitchTo().Frame("frame-right");
            var state = RightFrameElement.IsElementDisplayed();
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().DefaultContent();
            return state;
        }

        public bool IsBottomFrameExist()
        {
            driver.SwitchTo().Frame("frame-bottom");
            var state = BottomFrameElement.IsElementDisplayed();
            driver.SwitchTo().DefaultContent();
            return state;
        }
    }
}
