using Microsoft.VisualStudio.TestTools.UnitTesting;
using N_Ix_study_1.Common;
using N_Ix_study_1.SeleniumWebDriver;

namespace N_Ix_study_1.Basic
{
    [TestClass]
    public class GmailTests : BaseTest
    {
        GmailPage gmail;
        private string login, password;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            gmail = new GmailPage(driver);   
            login = TestContext.Properties["GmailLogin1"].ToString();
            password = TestContext.Properties["GmailPassword1"].ToString();
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }

        [TestMethod]
        public void LoginToGmail()
        {
            Logger.Get().Info("Open Gmail page");
            gmail.Open();
            Logger.Get().Info("Login to Gmail account");
            gmail.Login(login, password);

            //Is messages list displayed
            Assert.IsTrue(gmail.IsMessagesListDisplayed(), "Messages list was not loaded");
        }

        [TestMethod]
        public void LoginWithWrongCredentials()
        {
            gmail.Open();
            gmail.EnterLogin("abcdefgh");
            gmail.ClickNextOnLogin();

            Assert.IsTrue(gmail.IsPasswordFieldDisplayed(), "Login was incorrect, the password field is not displayed");
        }

        [TestMethod]
        public void GetLast10Emails()
        {
            gmail.Open();
            gmail.Login(login, password);
            gmail.GetEmailsByCSSSelector(10);
        }
    }
}
