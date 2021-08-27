using Infrastructure;
using Infrastructure.MyDriver;
using OpenQA.Selenium;
using System;

namespace PageObjects.Gmail
{
    public class GmailHomePage : BasePage
    {
        public IWebElement loginField, passwordField, loginNextButton, passwordNextButton;
        By loginFieldLocator = By.XPath("//INPUT[@id='identifierId']");
        By passwordFieldLocator = By.XPath("//INPUT[@type='password']");
        By loginNextButtonLocator = By.XPath("//DIV[@id='identifierNext']//BUTTON");
        By passwordNextButtonLocator = By.XPath("//DIV[@id='passwordNext']//BUTTON");
        public GmailHomePage(IWebDriver driver) : base(driver)
        {
        }

        public GmailHomePage Open()
        {
            driver.Navigate().GoToUrl("https://mail.google.com/mail");
            return this;
        }

        public EmailsListPage Login(string login, string password)
        {
            EnterLogin(login);
            ClickNextOnLogin();
            EnterPassword(password);
            ClickNextOnPassword();
            return new EmailsListPage(driver);
        }

        public GmailHomePage EnterLogin(string login)
        {
            try
            {
                Waits.WaitForElementToBeVisible(driver, loginFieldLocator);
                loginField = driver.FindElement(loginFieldLocator);
                loginField.SendKeys(login);
            }
            catch (Exception ex)
            {
                Logger.Get().Error("Unable to enter login: " + ex.Message);
                throw;
            }
            return this;
        }

        public GmailHomePage ClickNextOnLogin()
        {
            Waits.WaitForElementToBeClickable(driver, loginNextButtonLocator);
            loginNextButton = driver.FindElement(loginNextButtonLocator);
            loginNextButton.Click();
            return this;
        }

        public GmailHomePage EnterPassword(string password)
        {
            try
            {
                Waits.WaitForElementToBeVisible(driver, passwordFieldLocator);
                passwordField = driver.FindElement(passwordFieldLocator);
                passwordField.SendKeys(password);
            }
            catch (Exception ex)
            {
                Logger.Get().Error("Unable to enter password: " + ex.Message);
                throw;
            }
            return this;
        }

        public EmailsListPage ClickNextOnPassword()
        {
            Waits.WaitForElementToBeClickable(driver, passwordNextButtonLocator);
            passwordNextButton = driver.FindElement(passwordNextButtonLocator);
            passwordNextButton.Click();
            return new EmailsListPage(driver);
        }

        public bool IsPasswordFieldDisplayed()
        {
            try
            {
                driver.FindElement(passwordFieldLocator);
            }
            catch (NoSuchElementException ex)
            {
                Logger.Get().Error(ex.Message);
                return false;
            }
            return true;
        }
    }
}
