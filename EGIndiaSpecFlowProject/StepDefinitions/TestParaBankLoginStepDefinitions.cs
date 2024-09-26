using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestParaBankLoginStepDefinitions
    {

        private IWebDriver _driver;

        [Given(@"Users is on the parabank login page")]
        public void GivenUsersIsOnTheParabankLoginPage()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
            _driver.Manage().Window.Maximize();
        }

        [When(@"User enter ""([^""]*)""and""([^""]*)""")]
        public void WhenUserEnterAnd(string Username, string Password)
        {
            Thread.Sleep(3000);
            IWebElement usrname = _driver.FindElement(By.XPath("//input[@name='username']"));
            usrname.SendKeys(Username);

            Thread.Sleep(2000);
            IWebElement password = _driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys(Password);
        }

        [When(@"User Clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement Login = _driver.FindElement(By.XPath("//input[@value='Log In']"));
            Login.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User is navigate to home Page")]
        public void ThenUserIsNavigateToHomePage()
        {
            Thread.Sleep(2000);
            _driver.Close();
        }
    }
}
