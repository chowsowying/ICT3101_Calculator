using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDefectDensityStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorDefectDensityStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered (.*) defects and (.*) KLOC into the calculator")]
        public void WhenIHaveEnteredDefectsAndKLOCIntoTheCalculator(int defects, int kloc)
        {
            _result = _calculatorContext.Calculator.CalculateDefectDensity(defects, kloc);
        }

        [Then(@"the defect density result should be (.*) defects/KLOC")]
        public void ThenTheDefectDensityResultShouldBeDefectsPerKLOC(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

        [When(@"I have entered (.*) KLOC as the initial size, (.*) KLOC changed, (.*)% of it modified, and (.*) KLOC deleted")]
        public void WhenIHaveEnteredKLOCAsTheInitialSizeKLOCChangedOfItModifiedAndKLOCDeleted(int initialKloc, int changedKloc, double modifiedPercent, int deletedKloc)
        {
            _result = _calculatorContext.Calculator.CalculateSSIForSecondRelease(initialKloc, changedKloc, modifiedPercent, deletedKloc);
        }

        [Then(@"the SSI result should be (.*) KLOC")]
        public void ThenTheSSIResultShouldBeKLOC(int expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }
    }
}
