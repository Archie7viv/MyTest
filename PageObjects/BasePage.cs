using Infrastructure.MyDriver;
using OpenQA.Selenium;

namespace PageObjects
{
    public class BasePage
    {
        public IDriver driver;

        public BasePage(IDriver driver)
        {
            this.driver = driver;
        }
    }
}
