using Xunit;
using CalculatorLib;

namespace CalculatorLib.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum_WhenBothNumbersArePositive()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;

            // Act
            var result = calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_ReturnsCorrectSum_WhenBothNumbersAreNegative()
        {
            // Arrange
            var calculator = new Calculator();
            int a = -5;
            int b = -3;

            // Act
            var result = calculator.Add(a, b);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult_WhenFirstNumberIsLarger()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;

            // Act
            var result = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult_WhenSecondNumberIsLarger()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 3;
            int b = 5;

            // Act
            var result = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(-2, result);
        }
    }
}
