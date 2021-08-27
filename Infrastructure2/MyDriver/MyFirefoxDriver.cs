using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Infrastructure.MyDriver
{
    public class MyFirefoxDriver : Driver
    {
        public MyFirefoxDriver()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\AHETKA\source\repos\N-Ix study 1\N-Ix study 1\bin\Debug");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
        }
        public override string GetTextOfElement(By elementLocator)
        {
            return FindElement(elementLocator).Text;
        }
    }
}
