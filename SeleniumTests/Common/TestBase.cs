using Basic_OOP.BasicOOP.MyDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTests
{
    [TestClass]
    public class TestBase : Driver
    {
        public static string baseUrl = string.Empty;
        public static string browserType;
        public static bool driverType;
        public Driver myDriver;

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
                myDriver = new MyChromeDriver();
            }
            else
            {
                myDriver = new MyFirefoxDriver();
            }
            myDriver.MaximizeWindow();
            myDriver.Navigate(baseUrl);
        }

        [TestCleanup]
        public void TearDown()
        {
            myDriver.CloseBrowser();
        }
    }
}
