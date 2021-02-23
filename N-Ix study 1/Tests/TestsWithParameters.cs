using N_Ix_study_1.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace N_Ix_study_1.Tests
{
    [TestFixture, Category("WithParameters"), Parallelizable(ParallelScope.All)]
    public class TestsWithParameters : BaseTest
    {
        [Test]
        public void TestWithParameters([Values("one", "two", "three")] string text)
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            var searchText = driver.FindElement(By.CssSelector(".gLFyf"));
            searchText.SendKeys(text);
            searchText.SendKeys(Keys.Enter);
        }
    }
}
