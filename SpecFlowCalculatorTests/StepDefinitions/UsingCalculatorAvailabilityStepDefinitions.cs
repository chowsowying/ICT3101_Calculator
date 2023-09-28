using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorAvailabilityStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered (.*) hours for MTTF and (.*) hours for MTTR into the calculator and press MTBF")]
        public void WhenIHaveEnteredHoursForMTTFAndHoursForMTTRAndPressMTBF(double mttf, double mttr)
        {
            _result = _calculatorContext.Calculator.CalculateMTBF(mttf, mttr);
        }

        [When(@"I have entered (.*) hours for MTBF and (.*) hours for MTTF into the calculator and press Availability")]
        public void WhenIHaveEnteredHoursForMTBFAndHoursForMTTFAndPressAvailability(double mtbf, double mttf)
        {
            _result = _calculatorContext.Calculator.CalculateAvailability(mtbf, mttf);
        }

        [When(@"I have entered (.*) hours of total downtime and (.*) failures into the calculator and press MTTR")]
        public void WhenIHaveEnteredHoursOfTotalDowntimeAndFailuresAndPressMTTR(double totalDowntime, int failures)
        {
            _result = _calculatorContext.Calculator.CalculateMTTR(totalDowntime, failures);
        }

        [When(@"I have entered (.*) hours and (.*) failures into the calculator and press MTTF")]
        public void WhenIHaveEnteredHoursAndFailuresAndPressMTTF(double totalHours, int failures)
        {
            _result = _calculatorContext.Calculator.CalculateMTTF(totalHours, failures);
        }


        [Then(@"the MTBF result should be (.*) hours")]
        [Then(@"the MTTR result should be (.*) hours")]
        [Then(@"the MTTF result should be (.*) hours")]
        public void ThenTheResultShouldBeHours(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

        [Then(@"the availability result should be (.*)%")]
        public void ThenTheAvailabilityResultShouldBePercent(double expectedPercentage)
        {
            Assert.That(_result, Is.EqualTo(expectedPercentage).Within(0.1));
        }
    }

}
