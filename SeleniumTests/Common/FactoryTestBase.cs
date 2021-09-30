using Infrastructure;
using Infrastructure.MyDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumTests
{
    [TestClass]
    public class FactoryTestBase
    {
        public static IWebDriver myDriver;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        { 
            Configuration.Initialize(context);
        }

        [TestInitialize]
        public void TestSetup()
        {
            myDriver = WebDriverUtils.Get();
        }

        [TestCleanup]
        public void TearDown()
        {
            WebDriverUtils.Quit();
        }
    }
}
