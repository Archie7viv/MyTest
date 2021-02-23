using N_Ix_study_1.Common;
using N_Ix_study_1.SeleniumWebDriver;
using NUnit.Framework;
using System.Configuration;

namespace N_Ix_study_1.Basic
{
    
    [TestFixture, Category("Gmail"), Parallelizable(ParallelScope.All)]
    public class GmailTests : BaseTest
    {
        GmailPage gmail;
        
        [SetUp]
        public void Setup()
        {
            gmail = new GmailPage(driver);    
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        public void LoginToGmail()
        {
            gmail.Open();
            gmail.Login();

            //Is messages list displayed
            Assert.IsTrue(gmail.IsMessagesListDisplayed(), "Messages list was not loaded");
        }

        [Test]
        public void LoginWithWrongCredentials()
        {
            gmail.Open();
            gmail.EnterLogin("abcdefgh");
            gmail.ClickNextOnLogin();

            Assert.IsTrue(gmail.IsPasswordFieldDisplayed(), "Login was incorrect, the password field is not displayed");
        }

        [Test]
        public void GetLast10Emails()
        {
            gmail.Open();
            gmail.Login();
            gmail.GetEmailsByCSSSelector(10);
        }
    }
}
