using OpenQA.Selenium;

namespace Infrastructure.MyDriver
{
    public interface IDriver
    {
        void ClickOnButton(By elementLocator);

        string GetTextOfElement(By elementLocator);

        void MaximizeWindow();

        void Navigate(string url);

        void CloseBrowser();
    }
}
