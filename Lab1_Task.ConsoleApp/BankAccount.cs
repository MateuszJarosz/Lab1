using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Task.ConsoleApp { }
public class BankAccount
{ 
        private string  _AccountNumber;
        private string _Ownername;
        private decimal _Balance; 
        private string _Currency;
        private bool _IsActive;
        private string _BankName; 

    public string AccountNumber { get; private set; }
     
    public string Ownername { get; set; }

    public decimal  Balance { get => _Balance;  private set => _Balance=value; }
     

    public string Currency { get; private set; }

    public bool IsActive { get; private set; }
    public string BankName { get; private set; }
    public BankAccount (string accountNumber, string ownername, decimal balance, string currency, bool isActive, string bankName)
    {
        AccountNumber = accountNumber;
        Ownername = ownername;
        Balance = balance;
        Currency = currency;
        IsActive = true;
        BankName = bankName;
    }
    public string Deposit(int amount)
    {
        if (amount <= 0)
        {
            return "Deposit amount must be positive.";
        }
        Balance += amount;
        return $"Deposited {amount} {Currency}. New balance is {Balance} {Currency}.";
    }
    public string Withdraw(int amount)
    {
        if (amount <= 0)
        {
            return "Withdrawal amount must be positive.";
        }
        if (amount > Balance)
        {
            return "Insufficient funds.";
        }
        Balance -= amount;
        return $"Withdrew {amount} {Currency}. New balance is {Balance} {Currency}.";
    }
    public string TransferTo(BankAccount targetAccount, int amount)
    {
        if (targetAccount == null)
        {
            return "Target account is null.";
        }
        if (amount <= 0)
        {
            return "Transfer amount must be positive.";
        }
        if (amount > Balance)
        {
            return "Insufficient funds.";
        }
        Balance -= amount;
        targetAccount.Balance += amount;
        return $"Transferred {amount} {Currency} to account {targetAccount.AccountNumber}. New balance is {Balance} {Currency}.";
    }
    public string CloseAccount()
    {
        if (!IsActive)
        {
            return "Account is already closed.";
        }
        IsActive = false;
        return "Account closed successfully.";



    }
    
}
