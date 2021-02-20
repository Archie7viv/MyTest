using N_Ix_study_1.Common;
using N_Ix_study_1.SeleniumWebDriver;
using NUnit.Framework;
using System.Configuration;

namespace N_Ix_study_1.Basic
{
    
    [TestFixture, Category("Gmail"), ]
    public class GmailTests : BaseTest
    {
        static string parallelizationValue = ConfigurationManager.AppSettings["Parallelizable"];
        Gmail gmail;
        
        [SetUp]
        public void Setup()
        {
            gmail = new Gmail(driver);    
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        [Test, Parallelizable(parallelizationValue)]
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
