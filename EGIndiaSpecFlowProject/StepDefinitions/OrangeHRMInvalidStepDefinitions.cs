using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMInvalidStepDefinitions
    {
        private IWebDriver _driver;


        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text field")]
        public void WhenUserEntersTheAndInTheTextField(string usrname, string passwd)
        {
            Thread.Sleep(3000);
            IWebElement uname = _driver.FindElement(By.XPath("//input[@placeholder='Username']"));
            uname.SendKeys(usrname);

            Thread.Sleep(2000);
            IWebElement password = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            password.SendKeys(passwd);
        }

        [When(@"User clickss on login button")]
        public void WhenUserClickssOnLoginButton()
        {
            IWebElement loginBtn = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            loginBtn.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User receives a invalid login message")]
        public void ThenUserReceivesAInvalidLoginMessage()
        {
            IWebElement cellData = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            string textData = cellData.Text;
            Console.WriteLine(cellData.Text);
            Assert.That(textData, Is.EqualTo("Invalid credentials"));
            Thread.Sleep(2000);
            _driver.Close();
        }
    }
}
