namespace Infrastructure.MyDriver
{
    public class DriverUtils
    {
        public static IDriver myDriver;
        public static IDriver Get()
        {
            if(myDriver == null)
            {
                if (Configuration.BrowserType == "Chrome")
                {
                    myDriver = new MyChromeDriver();
                }
                else
                {
                    myDriver = new MyFirefoxDriver();
                }
            }
            //myDriver.MaximizeWindow();
            //myDriver.Navigate(baseUrl);
            return myDriver;
        }

        public static void Quit()
        {
            myDriver.CloseBrowser();
        }
    }
}
