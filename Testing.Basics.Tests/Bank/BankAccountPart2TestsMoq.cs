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
    public class BankAccountPart2TestsMoq
    {
        private readonly Mock<INotificationService> _notificationService;
        public BankAccountPart2TestsMoq()
        {
            _notificationService = new Mock<INotificationService>();
            //mockNotificationService.Setup(x => x.NotifyAllChannels(""));
            //_notificationService = mockNotificationService.Object;
        }

        [Fact]
        public void Deposit_WhenDepositingAmountGreaterThanZero_ReturnBalance()
        {
            _notificationService.Setup(x => x.NotifyAllChannels(""));
            var sut = new BankAccountPart2(_notificationService.Object)
            {
                Balance = 200
            };

            sut.Deposit(100);

            Assert.Equal(300, sut.Balance);

        }

        [Fact]
        public void Deposit_WhenAttemptingToDepositZeroAmount_ReturnZeroBalanceException()
        {
            var sut = new BankAccountPart2(_notificationService.Object);

            Assert.Throws<ZeroDepositException>(() => sut.Deposit(0));
        }
    }
}
