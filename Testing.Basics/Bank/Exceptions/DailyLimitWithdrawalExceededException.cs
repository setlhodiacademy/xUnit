using System;

namespace Testing.Basics.Exceptions
{
    public class DailyLimitWithdrawalExceededException : Exception
    {
        public DailyLimitWithdrawalExceededException(string error) : base(error)
        {
        }
    }
}
