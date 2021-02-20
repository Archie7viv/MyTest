using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace N_Ix_study_1.Common
{
    public class BaseTest
    {
        public IWebDriver driver;

        public BaseTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
    }
}
