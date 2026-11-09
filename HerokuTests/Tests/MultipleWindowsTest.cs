using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuTests.Pages;
using HerokuTests.Utils;

namespace HerokuTests.Tests
{
    public class MultipleWindowsTest : HerokuBaseTest
    {
        MultipleWindows multipleWindows = new MultipleWindows();
        WelcomePage welcomePage = new WelcomePage();

        [Test]
        public void CheckMultipleWindows()
        {
            welcomePage.ClickPageButton("Multiple Windows");
            var defaultWindow = BrowserUtils.GetIdCurrentTab();//здесь id первоначальной вкладки
            multipleWindows.ClickClickHere();
            var tabs =  BrowserUtils.GetAllTabs();//здесь id первоначальной и новой открытой вкладок
            var newWindow1 = tabs[1];
            BrowserUtils.SwitchToTab(newWindow1);
            bool isNewWindowExist = multipleWindows.IsNewWindowLabelExist();
            Assert.IsTrue(isNewWindowExist);
            BrowserUtils.SwitchToTab(defaultWindow);
            multipleWindows.ClickClickHere();
            var allTabs = BrowserUtils.GetAllTabs();//здесь id первоначальной, новой открытой и последней открытой вкладок
            var thirdTab = allTabs.Except(tabs).ToList();
            BrowserUtils.SwitchToTab(thirdTab[0]);
            bool isNewWindowExist2 = multipleWindows.IsNewWindowLabelExist();
            Assert.IsTrue(isNewWindowExist2);
        }
    }
}
