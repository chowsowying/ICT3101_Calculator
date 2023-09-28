using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;
        private Exception _exception;

        public UsingCalculatorFactorialStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        // Given I have a calculator is defiine already in "UsingCalculatorStepDefinition" file 
        // Using context injection, the state will still be shared across steps

        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int number)
        {
            try
            {
                _result = _calculatorContext.Calculator.Factorial(number);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

        [Then(@"an error should be displayed saying ""(.*)""")]
        public void ThenAnErrorShouldBeDisplayedSaying(string expectedErrorMessage)
        {
            Assert.IsNotNull(_exception, "Expected an exception to be thrown, but none was.");
            Assert.That(_exception.Message, Is.EqualTo(expectedErrorMessage));
        }

    }
}
