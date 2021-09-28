using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infrastructure
{
    public static class Configuration
    {
        public static string BaseUrl { get; private set; }
        public static string BrowserType { get; private set; }
        public static string Login { get; private set; }
        public static string Password { get; private set; }
        public static string W3SchoolsUrl { get; private set; }

        public static void Initialize(TestContext context)
        {
            if (context.Properties["TestEnvironmentUrl"] != null) 
            {
                BaseUrl = context.Properties["TestEnvironmentUrl"].ToString();
            }
            BrowserType = context.Properties["CurrentBrowser"].ToString();

            Login = context.Properties["GmailLogin1"].ToString();
            Password = context.Properties["GmailPassword1"].ToString();

            if (context.Properties["W3SchoolsUrl"] != null)
            {
                W3SchoolsUrl = context.Properties["W3SchoolsUrl"].ToString();
            }
            
        }
    }
}
