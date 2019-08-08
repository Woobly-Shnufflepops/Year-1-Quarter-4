using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersFinal
{
    public class Account : IEquatable
    {
        //Question 2
        private int _accountNumber;
        private decimal _balance;

        public Account(int AccountNumber, decimal Balance)
        {
            _accountNumber = AccountNumber;
            _balance = Balance;
        }

        public int AccountNumber { get { return _accountNumber; } }
        public decimal Balance { get { return _balance; } }

        public bool MyEquals(object other)
        {
            if (int.Parse(other.ToString()) == _accountNumber)
            {
                return true;
            }
            else return false;
        }
    }
}
