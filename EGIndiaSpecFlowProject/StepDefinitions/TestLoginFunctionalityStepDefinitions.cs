using System;
using TechTalk.SpecFlow;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestLoginFunctionalityStepDefinitions
    {
        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            //throw new PendingStepException();
            Console.WriteLine("Test user is on the login page");
        }

        [When(@"User enters the username and password")]
        public void WhenUserEntersTheUsernameAndPassword()
        {
            //throw new PendingStepException();
            Console.WriteLine("Test user enters the username and password");
        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            //throw new PendingStepException();
            Console.WriteLine("Test user clicks on the login button");
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            //throw new PendingStepException();
            Console.WriteLine("Test user navigates to the home page");
        }
    }
}
