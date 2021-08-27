using Infrastructure.MyDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace PageObjects.Gmail
{
    public class EmailsListPage : BasePage
    {
        By emailListContainer = By.XPath("//DIV[@class='aDP']");
        public string emailSubj;
        public EmailsListPage(IWebDriver driver) : base(driver)
        {
        }

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
            Waits.WaitForElementToBeVisible(driver, emailListContainer);
        }

        public bool IsMessagesListDisplayed()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
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
