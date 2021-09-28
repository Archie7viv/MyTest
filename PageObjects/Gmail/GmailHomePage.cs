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
        public GmailHomePage(IDriver driver) : base(driver)
        {
        }

        public GmailHomePage Open()
        {
            driver.Navigate(Configuration.BaseUrl);
            return this;
        }

        public EmailsListPage Login()
        {
            EnterLogin(Configuration.Login);
            ClickNextOnLogin();
            EnterPassword(Configuration.Password);
            ClickNextOnPassword();
            return new EmailsListPage(driver);
        }

        public GmailHomePage EnterLogin(string login)
        {
            try
            {
                driver.WaitForElementToBeVisible(loginFieldLocator);
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
            driver.WaitForElementToBeClickable(loginNextButtonLocator);
            loginNextButton = driver.FindElement(loginNextButtonLocator);
            loginNextButton.Click();
            return this;
        }

        public GmailHomePage EnterPassword(string password)
        {
            try
            {
                driver.WaitForElementToBeVisible(passwordFieldLocator);
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
            driver.WaitForElementToBeClickable(passwordNextButtonLocator);
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
