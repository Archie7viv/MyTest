using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumTests
{
    [TestClass]
    public class Tests : TestBase
    {
        By googleSearchLocator = By.XPath("//DIV[@class='FPdoLc tfB0Bf']//INPUT[@class='RNmpXc']");
        By firstLinkLocator = By.Id("latest-title");
        string linkText;

        [TestMethod]
        public void TestMethod1()
        {
            //FindElement() is unaccessible due to it's protection level
            //var searchText = myDriver.FindElement(By.CssSelector(".gLFyf")); 
            //searchText.SendKeys("one");
            //searchText.SendKeys(Keys.Enter);
        }

        [TestMethod]
        public void InterfaceTest()
        {
            myDriver.ClickOnButton(googleSearchLocator);
            linkText = myDriver.GetTextOfElement(firstLinkLocator);
        }
    }
}
