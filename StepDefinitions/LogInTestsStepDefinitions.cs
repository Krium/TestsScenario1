using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestsScenario1.PageObject;

namespace TestsScenario1.StepDefinitions
{
    [Binding]
    public class LogInTestsStepDefinitions
    {

        public IWebDriver driver;
        LogInPage logInPage;
        ProfilePage profilePage;
       
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [Given(@"Not-registered user opens '(.*)' page")]
        public void UserOpenPage(string url)
        {
            logInPage = new LogInPage(driver);
            logInPage.OpenPage(url);
        }

        [Then(@"User checks that he is presented with a login screen on '(.*)' page")]
        [Given(@"User checks that he is presented with a login screen on '(.*)' page")]
        public void UserChecksThatHeIsPresentedWithALoginScreenOnPage(string url)
        {
           Assert.That(driver.Url, Is.EqualTo(url));        
        }

       
        [When(@"User enter a valid username '(.*)'")]
        public void UserEnterAValidUsername(string username)
        {
            
            logInPage.SetValueToUserNameInput(username); 
        }

        [When(@"User enter a valid password '(.*)'")]
        public void UserEnterAValidPassword(string password)
        {
            logInPage.SetValueToPasswordInput(password);    
        }

        [When(@"User click on LogIn button")]
        public void WhenUserClickOnLogInButton()
        {
            logInPage.ClickOnLogInButton();
        }

        [Then(@"User checks that he is logged in successfully and '(.*)' is opened and keyword '(.*)' is dispayed")]
        public void UserChecksThatHeIsLoggedInSuccessfullyAndIsOpened(string url, string keyword)
        {           
            profilePage = new ProfilePage(driver); 
            Assert.That(driver.Url, Is.EqualTo(url));
            Assert.That(profilePage.GetTextFromGreetingMessage().Contains(keyword));
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
