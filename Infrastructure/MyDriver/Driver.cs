using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WaitHelpers = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;


namespace Infrastructure.MyDriver
{
    public abstract class Driver : IDriver
    {
        public IWebDriver driver;
        public bool isClickCalled;

        public virtual void ClickOnButton(By elementLocator)
        {
            ClickOnElement(elementLocator);
            isClickCalled = true;
        }

        public virtual string GetTextOfElement(By elementLocator)
        {
            return FindElement(elementLocator).Text;
        }

        protected void ClickOnElement(By elementLocator)
        {
            FindElement(elementLocator).Click();
        }

        internal IWebElement FindElement(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(WaitHelpers.ElementIsVisible(elementLocator));
            return driver.FindElement(elementLocator);
        }

        public void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
