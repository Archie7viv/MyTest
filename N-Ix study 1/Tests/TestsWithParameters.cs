using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace N_Ix_study_1.Tests
{
    [TestClass]
    public class TestsWithParameters
    {
        public IWebDriver driver;
        private string testUrl;
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext { get; set; }

        [TestMethod]
        public void HomePageTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            testUrl = TestContext.Properties["TestEnvironmentUrl"].ToString();

            driver.Navigate().GoToUrl(testUrl);
            var searchText = driver.FindElement(By.CssSelector(".gLFyf"));
            searchText.SendKeys("one");
            searchText.SendKeys(Keys.Enter);
        }

        [TestMethod]
        public void TestWithParameters([Values("one", "two", "three")] string text)
        {
            testUrl = TestContext.Properties["TestEnvironmentUrl"].ToString();

            driver.Navigate().GoToUrl(testUrl);
            var searchText = driver.FindElement(By.CssSelector(".gLFyf"));
            searchText.SendKeys(text);
            searchText.SendKeys(Keys.Enter);
        }
    }
}
