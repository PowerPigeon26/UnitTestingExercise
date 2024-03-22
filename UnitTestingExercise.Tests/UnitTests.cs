using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(56, 3, 77, 136)]
        [InlineData(2, 14, 8, 24)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();
            
            //Act
            var actual = instance.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 8, 2)]
        [InlineData(10, 0, 10)]
        [InlineData(-8, 8, -16)]
        [InlineData(10, 10, 0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();

            //Act
            var actual = instance.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(2, 8, 16)]
        [InlineData(7, 8, 56)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();

            //Act
            var actual = instance.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(15, 2, 7)]
        [InlineData(63, 3, 21)]
        public void DivideTest(int dividend, int divisor, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();

            //Act
            var actual = instance.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
