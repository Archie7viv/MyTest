using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestClass]
    public class Tests : TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl(baseUrl);
            var searchText = driver.FindElement(By.CssSelector(".gLFyf"));
            searchText.SendKeys("one");
            searchText.SendKeys(Keys.Enter);
        }
    }
}
