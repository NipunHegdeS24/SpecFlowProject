using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EGIndiaSpecFlowProject.Hooks
{
    [Binding]
    internal class Hooks
    {
        [BeforeScenario]
        public void Setup()
        {

            Console.WriteLine("Running before every scenario");

        }


        [AfterScenario]
        public void TearDown()
        {

            Console.WriteLine("Running after every scenario");

        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            TestContext.Progress.WriteLine("Running before TestRun");

        }


        [AfterTestRun]
        public static void AfterTestRun()
        {


            TestContext.Progress.WriteLine("Running after TestRun");


        }


        [BeforeStep]
        public void BeforeStep()
        {

            Console.WriteLine("Running before TestRun");

        }


        [AfterStep]
        public void AfterStep()
        {

            Console.WriteLine("Running after TestRun");

        }
    }
}
