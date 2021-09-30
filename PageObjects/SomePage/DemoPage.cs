using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects.SomePage
{
    public class DemoPage : FactoryBasePage
    {
        public DemoPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.CssSelector, Using = "#runbtn")]
        public IWebElement RunButton { get; set; }

        public void ClickRun()
        {
            RunButton.Click();
        }
    }
}
