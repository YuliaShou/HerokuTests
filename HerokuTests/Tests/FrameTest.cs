using HerokuTests.Pages;
using HerokuTests.SeleniumFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuTests.Tests
{
    public class FrameTest:BaseTest
    {
        FramesPage framesPage = new FramesPage();
        WelcomePage welcomePage = new WelcomePage();
        NestedFramePage nestedFramePage = new NestedFramePage();

        [Test] 
        public void NestedFrameTest()
        {
            welcomePage.ClickPageButton("Frames");
            framesPage.ClickFramePageButton("Nested Frames");
            //Assert.IsTrue(nestedFramePage.IsLeftFrameExist(), "Left Frame doesn't exist");
        }
    }
}
