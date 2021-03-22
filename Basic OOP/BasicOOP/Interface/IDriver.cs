using OpenQA.Selenium;

namespace Basic_OOP.BasicOOP.Interface
{
    public interface IDriver
    {
        public void ClickOnButton(By elementLocator);

        public string GetTextOfElement(By elementLocator);

        public void MaximizeWindow();

        public void Navigate(string url);

        public void CloseBrowser();
    }
}
