using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using WaitHelpers = SeleniumExtras.WaitHelpers.ExpectedConditions;


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

        public void ClickOnElement(By elementLocator)
        {
            FindElement(elementLocator).Click();
        }

        public IWebElement FindElement(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(WaitHelpers.ElementIsVisible(elementLocator));
            return driver.FindElement(elementLocator);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By elementLocator, int timeout = 5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(WaitHelpers.ElementIsVisible(elementLocator));
            return driver.FindElements(elementLocator);
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

        public void WaitForElementToBeVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(WaitHelpers.ElementIsVisible(locator));
        }

        public void WaitForElementToBeClickable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(WaitHelpers.ElementToBeClickable(locator));
        }
    }
}
