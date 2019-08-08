using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    // Savings account class that inherits from account class
    public class SavingsAccount:Account
    {
        // new field
        private double _interestRate;

        // new getter
        public double interestRate { get { return _interestRate; } }

        // new constructor
        public SavingsAccount(int accountNumber, decimal currentBalance, string bankName, double interestRate):base(accountNumber, currentBalance, bankName)
        {
            _interestRate = interestRate;
        }

        // Overriding the withdraw method
        new public decimal Withdraw(decimal amount)
        {
            if (CurrentBalance >= 0 && CurrentBalance - amount >= 0)
            {
                CurrentBalance -= amount;
                return CurrentBalance;
            }
            else return CurrentBalance - amount;
        }
    }
}
