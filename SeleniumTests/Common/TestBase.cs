using Infrastructure;
using Infrastructure.MyDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTests
{
    [TestClass]
    public class TestBase
    {
        public static IDriver myDriver;

        //[AssemblyInitialize]
        //public static void SetUp(TestContext context)
        //{ 
        //    Configuration.Initialize(context);
        //}

        //[TestInitialize]
        //public void TestSetup()
        //{
        //    myDriver = DriverUtils.Get();
        //}

        //[TestCleanup]
        //public void TearDown()
        //{
        //    WebDriverUtils.Quit();
        //}
    }
}
