using Infrastructure.MyDriver;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace PageObjects.Gmail
{
    public class EmailsListPage : BasePage
    {
        By emailListContainer = By.XPath("//DIV[@class='aDP']");
        public string emailSubj;
        public EmailsListPage(IDriver driver) : base(driver) { }

        public EmailsListPage GetEmailsByClass(int numberOfEmails)
        {
            IReadOnlyCollection<IWebElement> unreademail = driver.FindElements(By.ClassName("zE"));
            for (int i = 0; i < numberOfEmails; i++)
            {
                //do something
            }
            return this;
        }

        public EmailsListPage GetEmailsByCSSSelector(int numberOfEmails)
        {
            WaitForEmailList();
            IReadOnlyCollection<IWebElement> unreademail = driver.FindElements(By.CssSelector(".zE"));
            for (int i = 0; i < numberOfEmails; i++)
            {
                //do something
            }
            return this;
        }

        public void WaitForEmailList()
        {
            driver.WaitForElementToBeVisible(emailListContainer);
        }

        public bool IsMessagesListDisplayed()
        {
            try
            {
                driver.FindElement(By.ClassName("zE"));
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
            return true;
        }
    }
}
