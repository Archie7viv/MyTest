using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PageObjects
{
    public class FactoryBasePage
    {
        public IWebDriver driver;

        public FactoryBasePage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);
        }
    }
}
