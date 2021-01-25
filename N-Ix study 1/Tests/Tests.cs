using N_Ix_study_1.SeleniumWebDriver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Ix_study_1.Basic
{
    [TestFixture, Parallelizable(ParallelScope.All)]
    public class Tests
    {
        [Test]
        public void LoginToGmail()
        {
            GmailTask gmail = new GmailTask();
            gmail.OpenGmail();
            gmail.LoginToGmail();

            //Is messages list displayed
            Assert.IsTrue(gmail.IsMessagesListDisplayed(), "Messages list was not loaded");
        }

        [Test]
        public void LoginWithWrongCredentials()
        {
            GmailTask gmail = new GmailTask();
            gmail.OpenGmail();
            gmail.EnterLogin("abcdefgh");
            gmail.ClickNextOnLogin();

            Assert.IsTrue(gmail.IsPasswordFieldDisplayed(), "Login was incorrect, the password field is not displayed");
        }

        [Test]
        public void TestWithParameters([Values("one","two","three")] string text)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();

            var searchText = driver.FindElement(By.CssSelector(".gLFyf"));
            searchText.SendKeys(text);
            searchText.SendKeys(Keys.Enter);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Close();

        }
    }
}
