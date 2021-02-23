using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public class TestBase
    {
        public IWebDriver driver;
        private static string baseUrl = string.Empty;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();

        }

        [TestCleanup]
        public void TearDown()
        {

        }
    }
}
