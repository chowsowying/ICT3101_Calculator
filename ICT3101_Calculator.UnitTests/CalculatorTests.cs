using NUnit.Framework.Internal;
using System.Reflection.Metadata;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        // Part 13 -----------------------------------------------------------------

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act
            double result = _calculator.Subtract(25, 10);
            // Assert
            Assert.That(result, Is.EqualTo(15));
        }

    
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            // Act
            double result = _calculator.Multiply(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

 
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
        {
            // Act
            double result = _calculator.Divide(40, 5);
            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

   
        /* [test]
        public void divide_whendividingbyzero_resultsequalinfinity()
        {
            // act
            double result = _calculator.divide(40, 0);

            // assert
            Assert.that(result, is.equalto(double.positiveinfinity));

            // use positiveinfinity to signal that the division operation cannot be
            // completed because the divisor is zero,
            // and the result is undefined or infinite in a positive direction
        }
        */

    
        /*[Test]
        public void Divide_WhenDividingZeroByNumber_ResultsEqualToZero()
        {
            // Act
            double result = _calculator.Divide(0, 40);

            // Assert
            assert.That(result, Is.EqualTo(0));
        }
        */

    
        /*[Test]
        public void Divide_WhenDividingNumberByOne_ResultsEqualToDividend()
        {
            // Act
            double result = _calculator.Divide(40, 1);

            // Assert
            Assert.That(result, Is.EqualTo(40));
        }
        */

      
        /* [Test]
        public void Divide_WhenDividingNegativeNumber_ResultEqualToQuotient()
        {
            // Act
            double result = _calculator.Divide(-20, 4);

            // Assert
            Assert.That(result, Is.EqualTo(-5));
        }
       */

        // Part 14 a ------------------------------------------------------------

        /*[Test]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException()
        {
            // Act and Assert
            Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        } */


        // Part 14 b --------------------------------------------------------------

      /*  [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            // Act and Assert
            Assert.That(() => _calculator.Divide(a, b), Throws.TypeOf<ArgumentException>());
        }
*/
        // Part 15 --------------------------------------------------------------------------

        [Test]
        [TestCase(0, 1)] // Edge case
        [TestCase(1, 1)]
        [TestCase(3, 6)]
        [TestCase(10, 3628800)] // Large input
        public void Factorial_WithValidInputs_ReturnsCorrectResult(int input, double expectedValue)
        {
            // Act
            double result = _calculator.Factorial(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        [TestCase(5.5)]
        [TestCase(-3.7)]
        public void Factorial_WithInvalidInputs_ResultThrowsArgumentException(double input)
        {
            // Act and Assert
            Assert.That(() => _calculator.Factorial(input), Throws.TypeOf<ArgumentException>());
        }

        // Part 16 ---------------------------------------------------------------

        [Test]
        public void TriangleArea_WithValidInputs_ReturnsCorrectResult()
        {
            // height = 5, base length = 10, Expected area: 0.5 * base * height = 25

            // Act
            double result = _calculator.TriangleArea(5, 10); 

            // Assert
            Assert.That(result, Is.EqualTo(25)); 
        }

        [Test]
        [TestCase(-10, 5)]
        [TestCase(10, -5)]
        public void TriangleArea_WithNegativeValues_ResultThrowsArgumentException(double height, double baseLength)
        {
           

            // Act and Assert
            Assert.That(() => _calculator.TriangleArea(height, baseLength), Throws.ArgumentException);
        }

        [Test]
        public void CalculateCircleArea_WithValidInputs_ReturnsCorrectResult()
        {
            // radius = 5, Expected area: π * r^2 

            // Act
            double result = _calculator.CircleArea(5); 

            // Assert
            Assert.That(result, Is.EqualTo(Math.PI * 5 * 5)); 
        }

        [Test]
        public void CalculateCircleArea_WithNegativeRadius_ResultThrowsArgumentException()
        {

            // Act and Assert
            Assert.That(() => _calculator.CircleArea(-5), Throws.ArgumentException);
        }


        // Part 17 ------------------------------------------------------------------

        // Unknown Function A Unit Test

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        // Unknown Function B Unit Test

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }


        // Lab 4 ---------------------------------------------------------------

      /*  [Test]
        public void GenMagicNum_ValidFirstIndex_PositiveNumberFromMagicFile()
        {
            // Assuming the number at index 0 in MagicNumbers.txt is 5.5

            // Create an instance of FileReader
            IFileReader fileReader = new FileReader();

            // Call GenMagicNum with the fileReader instance
            double result = _calculator.GenMagicNum(0, fileReader);

            Assert.That(result, Is.EqualTo(11));
        }

        [Test]
        public void GenMagicNum_ValidPositiveIndex_PositiveNumberFromMagicFile()
        {
            // Assuming the number at index 1 in MagicNumbers.txt is 10.2

            // Create an instance of FileReader
            IFileReader fileReader = new FileReader();

            // Call GenMagicNum with the fileReader instance
            double result = _calculator.GenMagicNum(1, fileReader);

            Assert.That(result, Is.EqualTo(20.4));
        }

        [Test]
        public void GenMagicNum_ValidNegativeIndex_NegativeNumberFromMagicFile()
        {
            // Assuming the number at index 4 in MagicNumbers.txt is -12.5

            // Create an instance of FileReader
            IFileReader fileReader = new FileReader();

            // Call GenMagicNum with the fileReader instance
            double result = _calculator.GenMagicNum(4, fileReader);

            Assert.That(result, Is.EqualTo(25));
        }

        [Test]
        public void GenMagicNum_InvalidIndex_ThrowsIndexOutOfRangeException()
        {
            // This should throw an exception since there might not be a 10th number in the file

            // Create an instance of FileReader
            IFileReader fileReader = new FileReader();

            // Use a lambda expression to catch the exception
            Assert.That(() => _calculator.GenMagicNum(10, fileReader), Throws.TypeOf<ArgumentException>());
        }*/



    }
}