using N_Ix_study_1.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace N_Ix_study_1.Tests
{
    [TestFixture, Category("WithParameters")]
    public class TestsWithParameters : BaseTest
    {
        static  string[] values = ConfigurationManager.AppSettings["Parameters"].Split(',');

        [Test]
        public void TestWithParameters([Values(values)] string text)
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            var searchText = driver.FindElement(By.CssSelector(".gLFyf"));
            searchText.SendKeys(text);
            searchText.SendKeys(Keys.Enter);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
    }
}
