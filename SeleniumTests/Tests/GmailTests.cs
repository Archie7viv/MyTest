using Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.Gmail;
using SeleniumTests;

namespace N_Ix_study_1.Basic
{
    [TestClass]
    public class GmailTests : TestBase
    {
        private string login, password;
        public TestContext TestContext { get; set; }
        private GmailHomePage gmailHomePage;
        private EmailsListPage emailsListPage;

        [TestInitialize]
        public void Setup()
        {
            gmailHomePage = new GmailHomePage(myDriver);   
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
            gmailHomePage.Open();
            Logger.Get().Info("Login to Gmail account");
            emailsListPage = gmailHomePage.Login(login, password);

            //Is messages list displayed
            Assert.IsTrue(emailsListPage.IsMessagesListDisplayed(), "Messages list was not loaded");
        }

        [TestMethod]
        public void LoginWithWrongCredentials()
        {
            gmailHomePage.Open();
            gmailHomePage.EnterLogin("abcdefgh");
            gmailHomePage.ClickNextOnLogin();

            //Is password field displayed
            Assert.IsTrue(gmailHomePage.IsPasswordFieldDisplayed(), "Login was incorrect, the password field is not displayed");
        }

        [TestMethod]
        public void GetLast10Emails()
        {
            gmailHomePage.Open();
            emailsListPage = gmailHomePage.Login(login, password);
            emailsListPage.GetEmailsByCSSSelector(10);
        }
    }
}
