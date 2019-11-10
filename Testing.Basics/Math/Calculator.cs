using System;
using Testing.Basics.Exceptions;

namespace Testing.Basics.Math
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0)
                throw new DivisionByZeroException("Division by Zero is not allowed");

            return num1 / num2;
        }

        public double Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
