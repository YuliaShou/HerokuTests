using HerokuTests.Pages;
using HerokuTests.Utils;

namespace HerokuTests.Tests
{
    public class HerokuBaseTest
    {
        WelcomePage welcomePage = new WelcomePage();

        [SetUp]
        public void Setup()
        {
            welcomePage.OpenWelcomePage();
        }

        [TearDown]
        public void TearDown()
        {
            BrowserUtils.Quit();
        }
    }
}
