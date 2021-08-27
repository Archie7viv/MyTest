using Infrastructure.MyDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumTests
{
    [TestClass]
    public class TestBase : Driver
    {
        public static string baseUrl = string.Empty;
        public static string browserType;
        public static bool driverType;
        public IWebDriver myDriver;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            if (context.Properties["TestEnvironmentUrl"] != null)
            {
                baseUrl = context.Properties["TestEnvironmentUrl"].ToString();
            }
            browserType = context.Properties["CurrentBrowser"].ToString();
        }

        [TestInitialize]
        public void TestSetup()
        {
            if (browserType == "Chrome")
            {
                myDriver = (IWebDriver)new MyChromeDriver();
            }
            else
            {
                myDriver = (IWebDriver)new MyFirefoxDriver();
            }
            //myDriver.MaximizeWindow();
            //myDriver.Navigate(baseUrl);
        }

        [TestCleanup]
        public void TearDown()
        {
            //myDriver.CloseBrowser();
            myDriver.Quit();
        }
    }
}
