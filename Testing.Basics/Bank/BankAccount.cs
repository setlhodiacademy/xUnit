using System;
using System.Collections.Generic;
using System.Text;
using Testing.Basics.Exceptions;
using Testing.Basics.Services;

namespace Testing.Basics.Bank
{
    public class BankAccount
    {
        private double _balance;
        private double _dailyWithdrawalLimit = 500;

        public double Balance => _balance;


        public BankAccount(double balance)
        {
            _balance = balance;
        }
        public void Deposit(double amount)
        {
            if (amount == 0)
                throw new ZeroDepositException("Deposit amount must be greater than zero (0)");

            if (amount == -1)
                throw new ZeroDepositException("Deposit amount must be greater than zero (0)");

            _balance += amount;

            NotifyClient($"Your account balance is R{_balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > _balance)
                throw new InsufficientFundException("Deposit amount must be greater than zero (0)");

            if (amount > _dailyWithdrawalLimit)
                throw new DailyLimitWithdrawalExceededException($"Daily limit withdrawal of {this._dailyWithdrawalLimit} has been exceeded");

            _balance -= amount;

            NotifyClient($"Your account balance is R{_balance}");
        }

        private void NotifyClient(string message)
        {
            var notification = new NotificationService();
            notification.NotifyAllChannels(message);
        }

        public void SetDailyWithdrawalLimit(double dailyLimit)
        {
            this._dailyWithdrawalLimit = dailyLimit;
        }

        public double GetDailyWithdrawalLimit()
        {
            return this._dailyWithdrawalLimit;
        }

        public double GetBalance()
        {
            return this._balance;
        }
    }
}

