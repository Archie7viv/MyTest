using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestClass]
    public class TestBase
    {
        public static IWebDriver driver;
        public static string baseUrl = string.Empty;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            if (context.Properties["TestEnvironmentUrl"] != null)
            {
                baseUrl = context.Properties["TestEnvironmentUrl"].ToString();
            }
        }

        [TestInitialize]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
