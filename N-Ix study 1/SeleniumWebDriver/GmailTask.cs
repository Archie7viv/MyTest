using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace N_Ix_study_1.SeleniumWebDriver
{
    public class GmailTask
    {
        IWebDriver driver = new ChromeDriver();
        public IWebElement loginField, passwordField, loginNextButton, passwordNextButton;
        By loginFieldLocator = By.XPath("//INPUT[@id='identifierId']");
        By passwordFieldLocator = By.XPath("//INPUT[@type='password']");
        By loginNextButtonLocator = By.XPath("//DIV[@id='identifierNext']//BUTTON");
        By passwordNextButtonLocator = By.XPath("//DIV[@id='passwordNext']//BUTTON");
        public string emailSubj;

        private readonly string login = "nixautotest@gmail.com";
        private readonly string password = "MyT3sT20";
        
        
        public GmailTask() { }

        public void OpenGmail()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://mail.google.com/mail");
        }

        public void LoginToGmail()
        {
            EnterLogin();
            ClickNextOnLogin();
            EnterPassword();
            ClickNextOnPassword();
        }

        public void EnterLogin()
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

        public void WaitForElementToBeVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void WaitForElementToBeClickable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
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
            IReadOnlyCollection<IWebElement> unreademail = driver.FindElements(By.CssSelector(".zE"));
            for (int i = 0; i < numberOfEmails; i++)
            {
                //do something
            }
        }
    }
}
