using Calculator.Services;
using Calculator.Services.Interfaces;
using NUnit.Framework;

namespace Calculator.Test
{
    public class InputTest
    {
        private IInput _inputService;
        [SetUp]
        public void Setup()
        {
            _inputService = new InputRetriever();
        }

        [Test]
        public void PromptForIntegerTest()
        {
            //Arrange
            var prompt = "Input first number: ";

            //Act
            var result = _inputService.PromptForInteger(prompt);

            //Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void PromptForOperatorTest()
        {
            //Arrange
            var prompt = "Input operator(+, -, / or *): ";

            //Act
            var result = _inputService.PromptForOperator(prompt);

            //Assert
            Assert.AreEqual('+', result);
        }
    }
}
