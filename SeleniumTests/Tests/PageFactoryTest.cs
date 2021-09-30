using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.SomePage;

namespace SeleniumTests.Tests
{
    [TestClass]
    public class PageFactoryTest : FactoryTestBase
    {     
        [TestMethod]
        public void RunCodeOnW3Schools()
        {
            W3sCSPage w3sPage = new W3sCSPage(myDriver);
            w3sPage.Openw3sCSPage();

            DemoPage demoPage = w3sPage.ClickTryIt();

            demoPage.ClickRun();
        }
    }
}
