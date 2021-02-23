using N_Ix_study_1.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace N_Ix_study_1.SeleniumWebDriver
{
    public class GmailPage : BasePage
    {
        public IWebElement loginField, passwordField, loginNextButton, passwordNextButton;
        By loginFieldLocator = By.XPath("//INPUT[@id='identifierId']");
        By passwordFieldLocator = By.XPath("//INPUT[@type='password']");
        By loginNextButtonLocator = By.XPath("//DIV[@id='identifierNext']//BUTTON");
        By passwordNextButtonLocator = By.XPath("//DIV[@id='passwordNext']//BUTTON");
        By emailListContainer = By.XPath("//DIV[@class='aDP']");

        public string emailSubj;

        //private readonly string login = "nixautotest@gmail.com";
        private readonly string password = "MyT3sT20";       
        
        public GmailPage(IWebDriver driver) : base(driver)
        {
        }

        public void Open()
        {
            driver.Navigate().GoToUrl("https://mail.google.com/mail");
        }

        public void Login()
        {
            EnterLogin();
            ClickNextOnLogin();
            EnterPassword();
            ClickNextOnPassword();
        }

        public void EnterLogin(string login = "nixautotest@gmail.com")
        {
            WaitForElementToBeVisible(loginFieldLocator);
            loginField = driver.FindElement(loginFieldLocator);
            loginField.SendKeys(login);
        }

        public void ClickNextOnLogin()
        {
            WaitForElementToBeClickable(loginNextButtonLocator);
            loginNextButton = driver.FindElement(loginNextButtonLocator);
            loginNextButton.Click();
        }

        public void EnterPassword()
        {
            WaitForElementToBeVisible(passwordFieldLocator);
            passwordField = driver.FindElement(passwordFieldLocator);
            passwordField.SendKeys(password);
        }

        public void ClickNextOnPassword()
        {
            WaitForElementToBeClickable(passwordNextButtonLocator);
            passwordNextButton = driver.FindElement(passwordNextButtonLocator);
            passwordNextButton.Click();
        }

        public void WaitForEmailList()
        {
            WaitForElementToBeVisible(emailListContainer);
        }

        public void GetEmailsByClass(int numberOfEmails)
        {
            IReadOnlyCollection<IWebElement> unreademail = driver.FindElements(By.ClassName("zE"));
            for (int i = 0; i < numberOfEmails; i++)
            {
                //do something
            }
        }

        public void GetEmailsByCSSSelector(int numberOfEmails)
        {
            WaitForEmailList();
            IReadOnlyCollection<IWebElement> unreademail = driver.FindElements(By.CssSelector(".zE"));
            for (int i = 0; i < numberOfEmails; i++)
            {
                //do something
            }
        }

        public bool IsPasswordFieldDisplayed()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            try
            {
                driver.FindElement(passwordFieldLocator);
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
            return true;
        }

        public bool IsMessagesListDisplayed()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            try
            {
                driver.FindElement(By.ClassName("zE"));
            }
            catch(NoSuchElementException ex)
            {
                return false;
            }
            return true;
        }

        private void WaitForElementToBeVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        private void WaitForElementToBeClickable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
