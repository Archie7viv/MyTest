using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Infrastructure.MyDriver
{
    public interface IDriver
    {
        IWebElement FindElement(By elementLocator);

        ReadOnlyCollection<IWebElement> FindElements(By elementLocator, int timeout = 5);
        void ClickOnButton(By elementLocator);

        void ClickOnElement(By elementLocator);

        string GetTextOfElement(By elementLocator);

        void MaximizeWindow();

        void Navigate(string url);

        void CloseBrowser();

        void WaitForElementToBeVisible(By locator);

        void WaitForElementToBeClickable(By locator);
    }
}
