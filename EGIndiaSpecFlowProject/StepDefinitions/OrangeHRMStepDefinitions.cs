using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {
        private IWebDriver _driver;

        [Given(@"Users is on the orange hrm login page")]
        public void GivenUsersIsOnTheOrangeHrmLoginPage()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
        }

        [When(@"User enter the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEnterTheAndInTheTextFields(string username, string password)
        {
            Thread.Sleep(3000);
            IWebElement usrname = _driver.FindElement(By.XPath("//input[@placeholder='Username']"));
            usrname.SendKeys(username);

            Thread.Sleep(2000);
            IWebElement passwd = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            passwd.SendKeys(password);
           
        }

        [When(@"User click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            IWebElement loginBtn = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            loginBtn.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User is navigate to home page")]
        public void ThenUserIsNavigateToHomePage()
        {
            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));
            Admin.Click();
            _driver.Close();
        }
    }
}
