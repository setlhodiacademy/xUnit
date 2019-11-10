using System;
using System.Collections.Generic;
using System.Text;
using Testing.Basics.Exceptions;
using Testing.Basics.Math;
using Xunit;

namespace Testing.Basics.Tests.Math
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(0,2, 0)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        public void Multiply_WhenCalled_ReturnProductOfSuppliedParameters(int num1, int num2, int expected)
        {
            var sut = new Calculator();

            var result = sut.Multiply(num1, num2);

            Assert.Equal(expected, result);

        }

        [Fact]
        public void Divide_WhenCalledWithNum1AsZero_ThrowDivisionByZeroException()
        {
            var sut = new Calculator();

            Assert.Throws<DivisionByZeroException>(() => sut.Divide(0, 2));

        }

        [Fact]
        public void Divide_WhenCalledWithNum2AsZero_ThrowDivisionByZeroException()
        {
            var sut = new Calculator();

            Assert.Throws<DivisionByZeroException>(() => sut.Divide(2, 0));

        }

        //[Theory]
        //[InlineData(0,2)]
        //[InlineData(2, 0)]
        //public void Divide_WhenCalledEitherParameterAsZero_ThrowDivisionByZeroException(int num1, int num2)
        //{
        //    var sut = new Calculator();

        //    Assert.Throws<DivisionByZeroException>(() => sut.Divide(num1, num2));

        //}
    }
}
