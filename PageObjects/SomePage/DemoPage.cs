using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects.SomePage
{
    public class DemoPage
    {
        [FindsBy(How = How.CssSelector, Using = "//BUTTON[@id='runbtn']")]
        public IWebElement RunButton { get; set; }

        public void ClickRun()
        {
            RunButton.Click();
        }
    }
}
