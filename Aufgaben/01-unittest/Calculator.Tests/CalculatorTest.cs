using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Multiplikation()
        {
            int a = 6;
            int b = 4;
            Calculator calculator = new Calculator();

            int actual = calculator.Multiplication(a, b);

            Assert.Equal(24, actual);
        }

        [Fact]
        public void Division()
        {
            int a = 6;
            int b = 3;
            Calculator calculator = new Calculator();

            int actual = calculator.Division(a, b);

            Assert.Equal(2, actual);
        }
        [Fact]
        public void DivisionBy0()
        {
            int a = 6;
            int b = 0;
            Calculator calculator = new Calculator();

            Assert.Throws<ArgumentException>(() => calculator.Division(a, b));
        }
    }
}
