using Infrastructure;
using Infrastructure.MyDriver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PageObjects.SomePage
{
    public class W3sCSPage : FactoryBasePage
    {
        [FindsBy(How = How.LinkText, Using = "Try it Yourself »")]
        public IWebElement TryItButton { get; set; }

        public W3sCSPage(IWebDriver driver) : base(driver) 
        {
            
        }

        public void Openw3sCSPage()
        {
            driver.Navigate().GoToUrl(Configuration.W3SchoolsUrl);
        }
        public DemoPage ClickTryIt()
        {
            TryItButton.Click();
            WebDriverUtils.SwitchToNewTab();
            return new DemoPage(driver);
        }
    }
}
