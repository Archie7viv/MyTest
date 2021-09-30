using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.ObjectModel;

namespace Infrastructure.MyDriver
{
    public class WebDriverUtils
    {
        public static IWebDriver myDriver;
        public static IWebDriver Get()
        {
            if(myDriver == null)
            {
                if (Configuration.BrowserType == "Chrome")
                {
                    myDriver = new ChromeDriver();
                }
                else
                {
                    myDriver = new FirefoxDriver();
                }
            }
            //myDriver.MaximizeWindow();
            //myDriver.Navigate(baseUrl);
            return myDriver;
        }

        public static void Quit()
        {
            myDriver.Quit();
        }

        public static void SwitchToNewTab()
        {
            ReadOnlyCollection<string> windowHandles = Get().WindowHandles;

            if (windowHandles.Count <= 1)
            {
                return;
            }
            Get().SwitchTo().Window(windowHandles[windowHandles.Count - 1]);
        }
    }
}
