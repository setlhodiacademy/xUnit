using System;

public class DivisionByZeroException : Exception
{
    public DivisionByZeroException(string error) : base(error)
    {
    }
}
