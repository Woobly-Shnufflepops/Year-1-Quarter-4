using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    // Base class Account
    public class Account
    {
        // Fields
        private int _accountNumber;
        private decimal _currentBalance;
        private string _bankName;

        // Constructor
        public Account(int accountNumber, decimal currentBalance, string bankName)
        {
            _accountNumber = accountNumber;
            _currentBalance = currentBalance;
            _bankName = bankName;
        }

        //Getters and setters
        public int AccountNumber { get { return _accountNumber; } }
        public decimal CurrentBalance
        {
            get { return _currentBalance; }
            set { _currentBalance = value; }
        }
        public string BankName { get { return _bankName; } }

        // Methods
        public decimal Deposit(decimal amount)
        {
            if (amount >= 0) return CurrentBalance += amount;
            else return amount;
        }

        public decimal Withdraw(decimal amount)
        {
            if(CurrentBalance >= 0)
            {
                CurrentBalance -= amount;
                return CurrentBalance;
            }
            else return CurrentBalance - amount;
        }

        public static string Transfer(Account fromAccount, Account toAccount, decimal amount)
        {
            if(fromAccount.CurrentBalance >= amount)
            {
                fromAccount.CurrentBalance -= amount;
                toAccount.CurrentBalance += amount;
                return "Successfully transfered " + amount + " from " + fromAccount.AccountNumber + " to " + toAccount.AccountNumber;
            }
            else
            {
                return "Insufficent funds in " + fromAccount.AccountNumber + "! You have " + fromAccount.CurrentBalance + " and tried to transfer " + amount + "!";
            }
        }
    }
}
