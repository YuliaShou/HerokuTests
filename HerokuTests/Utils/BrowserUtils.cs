using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuTests.Utils
{
    public static class BrowserUtils
    {
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = Init();
                }
                return driver;
            }
        }

        private static IWebDriver Init()
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("disable-popup-blocking", true);
            options.AddArguments(
                "--no-sandbox",
                "--disable-dev-shm-usage",
                "--disable-gpu",
                "--window-size=1920,1080");
            var driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }

        public static void OpenPage(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            driver?.Quit();
            driver = null;
        }

        public static void RefreshPage()
        {
            driver.Navigate().Refresh();
        }

        public static void GoToBack()
        {
            driver.Navigate().Back();
        }

        public static string GetIdCurrentTab()
        {
            return driver.CurrentWindowHandle;
        }

        public static List<string> GetAllTabs()
        {
            return driver.WindowHandles.ToList();
        }

        public static void SwitchToTab(string tab)
        {
            driver.SwitchTo().Window(tab);
        }
    }
}


