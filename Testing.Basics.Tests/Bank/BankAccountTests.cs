using System;
using System.Collections.Generic;
using System.Text;
using Testing.Basics.Bank;
using Testing.Basics.Exceptions;
using Xunit;

namespace Testing.Basics.Tests.Bank
{
    public class BankAccountTests
    {
        [Fact(Skip = "Test fails due to being tightly coupled to Notification Service")]
        public void Deposit_WhenDepositingAmountGreaterThanZero_ReturnBalance()
        {
            //ARRANGE
            var sut = new BankAccount(200);

            //ACT
            sut.Deposit(100);

            //ASSERT
            Assert.Equal(300, sut.Balance);

        }

        [Fact]
        public void Deposit_WhenAttemptingToDepositZeroAmount_ReturnZeroBalanceException()
        {
            var sut = new BankAccount(200);

            Assert.Throws<ZeroDepositException>(() => sut.Deposit(0));
        }
    }
}
