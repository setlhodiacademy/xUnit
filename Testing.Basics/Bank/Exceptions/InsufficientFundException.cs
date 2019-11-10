using System;

namespace Testing.Basics.Exceptions
{
    public class InsufficientFundException : Exception
    {
        public InsufficientFundException(string error) : base(error)
        {
        }
    }
}
