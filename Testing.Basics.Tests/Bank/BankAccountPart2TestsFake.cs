using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Testing.Basics.Bank;
using Testing.Basics.Exceptions;
using Testing.Basics.Services;
using Xunit;

namespace Testing.Basics.Tests.Bank
{
    public class BankAccountPart2TestsFake
    {
        [Fact]
        public void Deposit_WhenDepositingAmountGreaterThanZero_ReturnBalance()
        {
            var sut = new BankAccountPart2(new NotificationServiceFake())
            {
                Balance = 200
            };

            sut.Deposit(100);

            Assert.Equal(300, sut.Balance);

        }

        [Fact]
        public void Deposit_WhenAttemptingToDepositZeroAmount_ReturnZeroBalanceException()
        {
            var sut = new BankAccountPart2(new NotificationServiceFake());

            Assert.Throws<ZeroDepositException>(() => sut.Deposit(0));
        }
    }
}
