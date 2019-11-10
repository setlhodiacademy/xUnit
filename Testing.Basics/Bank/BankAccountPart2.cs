using System;
using System.Collections.Generic;
using System.Text;
using Testing.Basics.Exceptions;
using Testing.Basics.Services;

namespace Testing.Basics.Bank
{
    public class BankAccountPart2
    {
        private readonly INotificationService _notificationService;

        public double Balance { get; set; }
        public double DailyWithdrawalLimit { get; set; } = 500;

        public BankAccountPart2(INotificationService notificationService)
        {
            this._notificationService = notificationService;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ZeroDepositException("Deposit amount must be greater than zero (0)");

            Balance += amount;

            _notificationService.NotifyAllChannels($"Your account balance is R{Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new InsufficientFundException("Deposit amount must be greater than zero (0)");

            if (amount > DailyWithdrawalLimit)
                throw new DailyLimitWithdrawalExceededException($"Daily limit withdrawal of {this.DailyWithdrawalLimit} has been exceeded");

            Balance -= amount;

            _notificationService.NotifyAllChannels($"Your account balance is R{Balance}");

        }

    }
}

