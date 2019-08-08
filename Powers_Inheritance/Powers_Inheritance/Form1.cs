// Author: Matthew Powers
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingLib;

namespace Powers_Inheritance
{
    public partial class Inheritance_Powers : Form
    {
        // Form load loads all the data from the preLoad function, adding it to the lsit
        public Inheritance_Powers()
        {
            InitializeComponent();
            preLoad();
        }
        // List with all the info in it
        List<Account> mixedAccounts = new List<Account>();

        // preload that loads all the data into the list when called
        public void preLoad()
        {
            mixedAccounts.Add(new CheckingAccount(00, 1000.00m, "BECU", 5.00m, 2.50m));
            mixedAccounts.Add(new CheckingAccount(01, 1000.00m, "BECU", 5.00m, 2.50m));
            mixedAccounts.Add(new CheckingAccount(02, 1000.00m, "BECU", 5.00m, 2.50m));
            mixedAccounts.Add(new CheckingAccount(03, 1000.00m, "BECU", 5.00m, 2.50m));
            mixedAccounts.Add(new CheckingAccount(04, 1000.00m, "BECU", 5.00m, 2.50m));

            mixedAccounts.Add(new SavingsAccount(05, 1000.00m, "BECU", 0.025));
            mixedAccounts.Add(new SavingsAccount(06, 1000.00m, "BECU", 0.025));
            mixedAccounts.Add(new SavingsAccount(07, 1000.00m, "BECU", 0.025));
            mixedAccounts.Add(new SavingsAccount(08, 1000.00m, "BECU", 0.025));
            mixedAccounts.Add(new SavingsAccount(09, 1000.00m, "BECU", 0.025));
        }

        // Method that casts the account to a checking or savings account, then takes all the elements, puts them into a new variable, and then displays the variables
        // to the richtextbox
        private void DisplayAccounts(Account checkSavings)
        {
            richTextBox1.AppendText(checkSavings.GetType().Name + ": ");
            if (checkSavings is CheckingAccount)
            {
                CheckingAccount ca = (CheckingAccount)checkSavings;
                int accountNumber = ca.AccountNumber;
                decimal currentBalance = ca.CurrentBalance;
                string bankName = ca.BankName;
                decimal minBalance = ca.minBalance;
                decimal fees = ca.fees;
                richTextBox1.AppendText(accountNumber.ToString() + " $" + currentBalance.ToString() + " " + bankName + " $" + minBalance.ToString() + " $" + fees.ToString() + "\n");
                richTextBox1.ScrollToCaret();
            }
            else if(checkSavings is SavingsAccount)
            {
                SavingsAccount sa = (SavingsAccount)checkSavings;
                int accountNumber = sa.AccountNumber;
                decimal currentBalance = sa.CurrentBalance;
                string bankName = sa.BankName;
                double interestRate = sa.interestRate;
                richTextBox1.AppendText(accountNumber.ToString() + " $" + currentBalance.ToString() + " " + bankName + " " + interestRate.ToString() + "%\n");
                richTextBox1.ScrollToCaret();
            }
        }

        // Button that clears the text box then calls DisplayAccounts, looping through each account
        private void btnDisplayAccounts_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach(Account i in mixedAccounts)
            {
                DisplayAccounts(i);
            }
        }

        // Button that gets which account to deposit to, then deposits the amount
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(decimal.Parse(txtAmount.Text) > 0)
            {
                mixedAccounts[int.Parse(txtAccountIndex.Text)].Deposit(decimal.Parse(txtAmount.Text));
            }
        }

        // Button that casts the account to a checking or savings account, then calls the withdraw function
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(mixedAccounts[int.Parse(txtAccountIndex.Text)] is CheckingAccount)
            {
                CheckingAccount ca = (CheckingAccount)mixedAccounts[int.Parse(txtAccountIndex.Text)];
                ca.Withdraw(decimal.Parse(txtAmount.Text));
            }
            else if(mixedAccounts[int.Parse(txtAccountIndex.Text)] is SavingsAccount)
            {
                SavingsAccount sa = (SavingsAccount)mixedAccounts[int.Parse(txtAccountIndex.Text)];
                sa.Withdraw(decimal.Parse(txtAmount.Text));
            }
        }

        // Button that calls the transfer method, and transfers money
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Account.Transfer(mixedAccounts[int.Parse(txtFromAccount.Text)], mixedAccounts[int.Parse(txtToAccount.Text)], decimal.Parse(txtTransferAmount.Text));
        }
    }
}
