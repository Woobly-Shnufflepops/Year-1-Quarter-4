using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    // Checking account class that inherits from Account class
    public class CheckingAccount:Account
    {
        // New fields
        private decimal _minBalance;
        private decimal _fees;

        // new getters and setters
        public decimal minBalance { get { return _minBalance; } }
        public decimal fees { get { return _fees; } }

        // New constructor
        public CheckingAccount(int accountNumber, decimal currentBalance, string bankName, decimal MinBalance, decimal Fees):base(accountNumber, currentBalance, bankName)
        {
            _fees = Fees;
            _minBalance = MinBalance;
        }

        // Overriding the withdraw method
        new public decimal Withdraw(decimal amount)
        {
            if (CurrentBalance >= 0 && amount <= CurrentBalance && (CurrentBalance - amount) >= minBalance)
            {
                CurrentBalance -= amount;
                return CurrentBalance;
            }
            else
            {
                return CurrentBalance -= fees;
            }
        }
    }
}
