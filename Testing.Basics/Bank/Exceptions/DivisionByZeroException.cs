using System;

namespace Testing.Basics.Exceptions
{
    public class DivisionByZeroException : Exception
    {
        public DivisionByZeroException(string error) : base(error)
        {
        }
    }
}
