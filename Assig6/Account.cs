using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig6
{
    class Account
    {
        private static double balance;
        private double dailyAmount;

        public Account(double amount)
        {
            Balance = amount;
        }

        public Account()
        {
            Balance = 100;
        }

        [ContractInvariantMethod]
        private void DailyBalanceChecker()
        {
            Contract.Invariant(dailyAmount < 5000, "Your use would be above your daily limit");
            Contract.Invariant(Balance > 50, "Your method sucks");
        }

        public void Deposit(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Ensures(Contract.OldValue(Balance) + amount == Balance);
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Ensures(Contract.OldValue(Balance) - amount == Balance);
            if (amount > Balance) throw new InvalidOperationException("The amount is bigger then your balance");
            Balance -= amount;
        }


        public static double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }
    }
}
