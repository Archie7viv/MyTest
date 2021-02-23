using Microsoft.VisualStudio.TestTools.UnitTesting;
using N_Ix_study_1.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace N_Ix_study_1.Tests
{
    //[TestFixture, Category("WithParameters"), Parallelizable(ParallelScope.All)]
    [TestClass]
    public class TestsWithParameters/* : BaseTest*/
    {
        public IWebDriver driver;
        private static string parallelization;
        private string testUrl;
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext { get; set; }

        [TestMethod]
        public void HomePageTest()
        {
            //parallelization = TestContext.Properties["Parallelization"].ToString();
            //testUrl = TestContext.Properties["TestEnvironmentUrl"].ToString();
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            testUrl = TestContext.Properties["TestEnvironmentUrl"].ToString();

            driver.Navigate().GoToUrl(testUrl);
            var searchText = driver.FindElement(By.CssSelector(".gLFyf"));
            searchText.SendKeys("one");
            searchText.SendKeys(Keys.Enter);
        }

        [Test]
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
