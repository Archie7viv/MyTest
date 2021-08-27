using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Infrastructure.MyDriver
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
