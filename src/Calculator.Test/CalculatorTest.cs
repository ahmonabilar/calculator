using Calculator.Services;
using Calculator.Services.Interfaces;
using NUnit.Framework;

namespace Calculator.Test
{
    public class Tests
    {
        private ICalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new CalculatorService();
        }

        [Test]
        public void AddTest()
        {
            //Arrange
            const int first = 1;
            const int second = 2;

            //Act
            var result = _calculator.Add(first, second);

            //Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void SubtractTest()
        {
            //Arrange
            const int first = 1;
            const int second = 2;

            //Act
            var result = _calculator.Subtract(first, second);

            //Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void MultiplyTest()
        {
            //Arrange
            const int first = 1;
            const int second = 2;

            //Act
            var result = _calculator.Multiply(first, second);

            //Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void DivideTest()
        {
            //Arrange
            const int dividend = 1;
            const int divisor = 2;

            //Act
            var result = _calculator.Divide(dividend, divisor);

            //Assert
            Assert.AreEqual(.5, result);
        }
    }
}