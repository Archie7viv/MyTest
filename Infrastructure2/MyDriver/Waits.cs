using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using WaitHelpers = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Infrastructure.MyDriver
{
    public static class Waits
    {
        public static void WaitForElementToBeVisible(IWebDriver driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(WaitHelpers.ElementIsVisible(locator));
        }

        public static void WaitForElementToBeClickable(IWebDriver driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(WaitHelpers.ElementToBeClickable(locator));
        }
    }
}
