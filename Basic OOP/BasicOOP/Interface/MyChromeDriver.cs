using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Basic_OOP.BasicOOP.Interface
{
    public class MyChromeDriver : Driver
    {
        public MyChromeDriver()
        {
            driver = new ChromeDriver();
        }

        public override void ClickOnButton(By elementLocator)
        {
            ClickOnElement(elementLocator);
        }
    }
}
