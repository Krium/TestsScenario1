using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Infrastructure;
using SeleniumExtras.PageObjects;
using NUnit.Framework.Internal;


namespace TestsScenario1.PageObject
{
    internal class LogInPage
    {
        protected IWebDriver _driver;
        protected WebDriverWait _wait;
        public LogInPage (IWebDriver driver) 
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='username']")]
        private IWebElement userNameInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        public IWebElement passwordInput;

        [FindsBy(How = How.XPath, Using = "//button[@name='submit']")]
        public IWebElement logInBtn;

        public void ClickOnLogInButton() { logInBtn.Click(); }        

        public void SetValueToPasswordInput(string value)
        {
            _wait.Until(d => passwordInput.Displayed);
            passwordInput.Clear();
            passwordInput.SendKeys(value);           
        }
        public void SetValueToUserNameInput(string value)
        {
            _wait.Until(d => userNameInput.Displayed);
            userNameInput.Clear();
            userNameInput.SendKeys(value);            
        }

        public void OpenPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

    }
}
