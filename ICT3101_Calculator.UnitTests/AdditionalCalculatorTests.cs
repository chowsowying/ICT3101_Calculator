using Moq;
using NUnit.Framework.Internal;
using System.Reflection.Metadata;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
                fr.Read("C:\\Users\\chows\\source\\repos\\ICT3101_Calculator\\ICT3101_Calculator\\MagicNumbers.txt"))
                .Returns(new string[5] { "5.5", "10.2", "15.3", "20.4", "-12.5" });
            _calculator = new Calculator();
        }

        // Lab 4 ---------------------------------------------------------------
        [Test]
        public void GenMagicNum_ValidFirstIndex_PositiveNumberFromMagicFile()
        {
            // Assuming the number at index 0 in MagicNumbers.txt is 5.5

            // Call GenMagicNum with the mock IFileReader instance
            double result = _calculator.GenMagicNum(0, _mockFileReader.Object);

            Assert.That(result, Is.EqualTo(11));
        }

        [Test]
        public void GenMagicNum_ValidPositiveIndex_PositiveNumberFromMagicFile()
        {
            // Assuming the number at index 1 in MagicNumbers.txt is 10.2

            // Call GenMagicNum with the mock IFileReader instance
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);

            Assert.That(result, Is.EqualTo(20.4));
        }

        [Test]
        public void GenMagicNum_ValidNegativeIndex_NegativeNumberFromMagicFile()
        {
            // Assuming the number at index 4 in MagicNumbers.txt is -12.5

            // Call GenMagicNum with the mock IFileReader instance
            double result = _calculator.GenMagicNum(4, _mockFileReader.Object);

            Assert.That(result, Is.EqualTo(25));
        }

        [Test]
        public void GenMagicNum_InvalidIndex_ThrowsIndexOutOfRangeException()
        {
            // This should throw an exception since there might not be a 10th number in the file

            // Use a lambda expression to catch the exception
            Assert.That(() => _calculator.GenMagicNum(10, _mockFileReader.Object), Throws.TypeOf<ArgumentException>());
        }



    }
}