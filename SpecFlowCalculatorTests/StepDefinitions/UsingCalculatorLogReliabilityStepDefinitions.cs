using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorLogReliabilityStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorLogReliabilityStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered (.*) as lambda0, (.*) as tether,and (.*) as mu into the calculator")]
        public void WhenIHaveEnteredValuesForCurrentFailureIntensityLogModel(double lambda0, double theta, double mu)
        {
            _result = _calculatorContext.Calculator.CalculateCurrentFailureIntensityLogModel(lambda0, theta, mu);
        }

        [Then(@"the failure intensity result should be (.*)")]
        public void ThenTheFailureIntensityResultShouldBe(double expected)
        {
            Assert.That(Math.Round(_result, 2), Is.EqualTo(expected));
        }

        [When(@"I have entered (.*) as lambda0, (.*) as tether, and (.*) as tau into the calculator")]
        public void WhenIHaveEnteredValuesForExpectedFailuresLogModel(double lambda0, double theta, double tau)
        {
            _result = _calculatorContext.Calculator.CalculateExpectedFailuresLogModel(lambda0, theta, tau);
        }

        [Then(@"the expected failures result should be (.*)")]
        public void ThenTheExpectedFailuresResultShouldBe(double expected)
        {
            Assert.That(Math.Round(_result), Is.EqualTo(expected));
        }
    }
}
