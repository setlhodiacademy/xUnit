using System;

namespace Testing.Basics.Exceptions
{
    public class ZeroDepositException : Exception
    {
        public ZeroDepositException(string error) : base(error)
        {
        }
    }
}
