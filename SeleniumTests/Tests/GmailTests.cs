using Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.Gmail;
using SeleniumTests;

namespace N_Ix_study_1.Basic
{
    [TestClass]
    public class GmailTests : TestBase
    {
        [TestMethod]
        public void LoginToGmail()
        {
            GmailHomePage gmailHomePage = new GmailHomePage(myDriver);
            Logger.Get().Info("Open Gmail page");
            gmailHomePage.Open();
            Logger.Get().Info("Login to Gmail account");
            EmailsListPage emailsListPage = gmailHomePage.Login();

            //Is messages list displayed
            Assert.IsTrue(emailsListPage.IsMessagesListDisplayed(), "Messages list was not loaded");
        }

        [TestMethod]
        public void LoginWithWrongCredentials()
        {
            GmailHomePage gmailHomePage = new GmailHomePage(myDriver);
            gmailHomePage.Open();
            gmailHomePage.EnterLogin("abcdefgh");
            gmailHomePage.ClickNextOnLogin();

            //Is password field displayed
            Assert.IsTrue(gmailHomePage.IsPasswordFieldDisplayed(), "Login was incorrect, the password field is not displayed");
        }

        [TestMethod]
        public void GetLast10Emails()
        {
            GmailHomePage gmailHomePage = new GmailHomePage(myDriver);
            gmailHomePage.Open();
            EmailsListPage emailsListPage = gmailHomePage.Login();
            emailsListPage.GetEmailsByCSSSelector(10);
        }
    }
}
