using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorBasicReliabilityStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered the initial failure intensity is (.*) failures/cpu-hr and It has experienced (.*) failures and it will experience (.*) failures in infinte time into the calculator and press Current failure intensity")]
        public void WhenIHaveEnteredValuesForCurrentFailureIntensity(double lambda0, double mu, double v0)
        {
            _result = _calculatorContext.Calculator.CalculateCurrentFailureIntensity(lambda0, mu, v0);
        }

        [When(@"I have entered the initial failure intensity is (.*) failures/cpu-hr and It has experienced (.*) failures and it will experience (.*) failures in infinte time and failures are (.*) CPU-hr into the calculator and press Average Number of expected failure")]
        public void WhenIHaveEnteredValuesForAverageExpectedFailures(double lambda0, double mu, double v0, double tau)
        {
            _result = _calculatorContext.Calculator.CalculateAverageExpectedFailures(lambda0, mu, v0, tau);
        }

        [Then(@"the Current failure intensityresult should be (.*) failures/cpu-hr")]
        [Then(@"the Average Number of expected failure result should be (.*) failures/cpu-hr")]
        public void ThenTheResultShouldBeFailuresPerCpuHr(double expected)
        {
            _result = Math.Round(_result);
            Assert.That(_result, Is.EqualTo(expected));
        }

    }

}
