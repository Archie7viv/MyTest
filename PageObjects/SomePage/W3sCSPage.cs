using Infrastructure;
using Infrastructure.MyDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects.SomePage
{
    public class W3sCSPage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "//a[text()='Try it Yourself »']")]
        public IWebElement TryItButton { get; set; }

        public W3sCSPage(IDriver driver) : base(driver) { }

        public void Openw3sCSPage()
        {
            driver.Navigate(Configuration.W3SchoolsUrl);
        }
        public DemoPage ClickTryIt()
        {
            TryItButton.Click();
            return new DemoPage();
        }
    }
}
