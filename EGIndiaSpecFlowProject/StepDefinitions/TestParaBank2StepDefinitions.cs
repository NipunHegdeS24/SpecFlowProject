using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestParaBank2StepDefinitions
    {

        private IWebDriver _driver;

        [Given(@"User is on Regestration Page")]
        public void GivenUserIsOnRegestrationPage()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
            _driver.Manage().Window.Maximize();
        }

        [When(@"User Enters ""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersAnd(string fname, string lname, string address, string city, string state, string zipCode, string phone, string ssn, string username, string password, string confirmPass)
        {
            Thread.Sleep(3000);
            IWebElement firstname = _driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            firstname.SendKeys(fname);

            Thread.Sleep(2000);
            IWebElement lastname = _driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            lastname.SendKeys(lname);

            Thread.Sleep(3000);
            IWebElement Address = _driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            Address.SendKeys(address);

            Thread.Sleep(2000);
            IWebElement City = _driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            City.SendKeys(city);

            Thread.Sleep(3000);
            IWebElement State = _driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            State.SendKeys(state);

            Thread.Sleep(2000);
            IWebElement zipcode = _driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            zipcode.SendKeys(zipCode);

            Thread.Sleep(3000);
            IWebElement Phone = _driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            Phone.SendKeys(phone);

            Thread.Sleep(2000);
            IWebElement SSN = _driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            SSN.SendKeys(ssn);

            Thread.Sleep(3000);
            IWebElement usrname = _driver.FindElement(By.XPath("//input[@id='customer.username']"));
            usrname.SendKeys(username);

            Thread.Sleep(2000);
            IWebElement Password = _driver.FindElement(By.XPath("//input[@id='customer.password']"));
            Password.SendKeys(password);

            Thread.Sleep(3000);
            IWebElement confirmpass = _driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            confirmpass.SendKeys(confirmPass);
            Thread.Sleep(2000);

        }

        [When(@"User Click on Register button")]
        public void WhenUserClickOnRegisterButton()
        {
            IWebElement register = _driver.FindElement(By.XPath("//input[@value='Register']"));
            register.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User is navigated to Regestration Page")]
        public void ThenUserIsNavigatedToRegestrationPage()
        {
            Console.WriteLine("User is navigated to Regestration Page");
            Thread.Sleep(1000);
            _driver.Close();
        }
    }
}
