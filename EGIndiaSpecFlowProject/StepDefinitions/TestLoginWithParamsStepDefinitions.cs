using System;
using TechTalk.SpecFlow;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestLoginWithParamsStepDefinitions
    {
        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            //throw new PendingStepException();
            Console.WriteLine($"The username is {username} and the password is {password}");
        }

        [Then(@"User selected city and country information")]
        public void ThenUserSelectedCityAndCountryInformation(Table table)
        {
            //throw new PendingStepException();
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city + ", " + country);
            }
        }

    }
}
