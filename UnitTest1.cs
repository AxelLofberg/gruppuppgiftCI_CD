using Xunit;
using SimpleCalculator;

namespace SimpleCalculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            double num1 = 5;
            double num2 = 7;

            // Act
            double result = Calculator.Add(num1, num2);

            // Assert
            Assert.Equal(12, result);
        }
    }
}
