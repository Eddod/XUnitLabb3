using System;
using System.Collections.Generic;
using Xunit;
using XUnitLabb3;

namespace XUnitLabb3Test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 5, 4)]
        [InlineData(-10, 20, 10)]
        [InlineData(-10, -10, -20)]
        public void Add_Should_Work(decimal value1, decimal value2, decimal result)
        {
            //Arrange
            Calculator cal = new Calculator()
            {
                X = value1,
                Y = value2,
                Result = result
            };
            //Act
            cal.Add();

            //assert
            Assert.Equal(result, cal.Result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(15, 2, 7.5)]
        [InlineData(-15, -2, 7.5)]
        [InlineData(-20, 10, -2)]
        public void Divide_Should_Work(decimal value1, decimal value2, decimal result)
        {
            //Arrange
            Calculator cal = new Calculator()
            {
                X = value1,
                Y = value2,
                Result = result
            };
            cal.Divide();
            Assert.Equal(result, cal.Result);
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(-1, 5, -6)]
        [InlineData(-10, 20, -30)]
        [InlineData(-10, 10, -20)]
        public void Subtract_Should_Work(decimal value1, decimal value2, decimal result)
        {
            //Arrange
            Calculator cal = new Calculator()
            {
                X = value1,
                Y = value2,
                Result = result
            };
            //Act
            cal.Subtract();

            //assert
            Assert.Equal(result, cal.Result);
        }

        [Theory]
        [InlineData(50, -20, -1000)]
        [InlineData(20, 258, 5160)]
        [InlineData(-100, -100, 10000)]
        public void Multiply_Should_Work(decimal value1, decimal value2, decimal result)
        {
            //Arrange
            Calculator cal = new Calculator()
            {
                X = value1,
                Y = value2,
                Result = result
            };
            //Act
            cal.Multiply();

            //assert
            Assert.Equal(result, cal.Result);
        }

        [Fact]
        public void Catch_Divide_ByZero_Exception()
        {
            //Arrange
            Calculator cal = new Calculator()
            {
                X = 10,
                Y = 0
            };

            var exception = Assert.Throws<DivideByZeroException>(() => cal.Divide());
            Assert.Equal("Attempted to divide by zero.", exception.Message);
        }
    }
}
