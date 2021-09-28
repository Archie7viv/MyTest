using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.SomePage;

namespace SeleniumTests.Tests
{
    [TestClass]
    public class PageFactoryTest : TestBase
    {
        W3sCSPage w3sPage = new W3sCSPage(myDriver);
        DemoPage demoPage;

        [TestMethod]
        public void RunCodeOnW3Schools()
        {
            w3sPage.Openw3sCSPage();

            demoPage = w3sPage.ClickTryIt();

            demoPage.ClickRun();
        }
    }
}
