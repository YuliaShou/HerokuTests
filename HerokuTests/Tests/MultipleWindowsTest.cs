using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuTests.Pages;
using HerokuTests.Utils;

namespace HerokuTests.Tests
{
    public class MultipleWindowsTest : BaseTest
    {
        MultipleWindows multipleWindows = new MultipleWindows();
        WelcomePage welcomePage = new WelcomePage();

        [Test]
        public void CheckMultipleWindows()
        {
            welcomePage.ClickPageButton("Multiple Windows");
            var defaultWindow = BrowserUtils.GetIdCurrentTab();
            multipleWindows.ClickClickHere();
            var tabs =  BrowserUtils.GetAllTabs();
            var newWindow1 = tabs[1];
            BrowserUtils.SwitchToTab(newWindow1);
            bool isNewWindowExist = multipleWindows.IsNewWindowLabelExist();
            Assert.IsTrue(isNewWindowExist);
        }
    }
}
