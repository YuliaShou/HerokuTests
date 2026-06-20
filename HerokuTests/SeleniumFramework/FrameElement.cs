using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.SeleniumFramework
{
    public class FrameElement : BaseElement
    {
        public FrameElement(By locator, int timeOutSeconds = 10) : base(locator, timeOutSeconds) { }

        public void SwitchTo()
        {
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//frame[@name='frame-left']")));
            var state = Driver.FindElement(By.XPath("//body[contains(text(), 'LEFT')]")).Enabled;
        }
    }
}
