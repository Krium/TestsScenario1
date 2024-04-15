using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsScenario1.PageObject
{
    internal class ProfilePage
    {
        protected IWebDriver _driver;
        protected WebDriverWait _wait;
        public ProfilePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h2[@id='greeting']")]
        private IWebElement greetingMessage;

        public string GetTextFromGreetingMessage()
        {
            return greetingMessage.Text;
        }
    }
}
