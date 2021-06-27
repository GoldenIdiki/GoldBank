using GoldBankLite.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBankLite.Core.Interface
{
    public interface IAccountServices
    {
        bool Deposit(string accountNumber, decimal amount, string note = "deposit");
        bool Withdrawal(string accountNumber, decimal amount, string note = "withdraw");
        bool Transfer(string debitAccountNumber, string creditAccountNumber, decimal amount, string note = "transfer");
        List<Transaction> GetStatementOfAccount(string accountNumber);
        decimal GetBalance(string accountNumber);
    }
}

// Anything CRUD => repository
// Business logic or functionalities or requirements => services
// What helps you easily abstract codes, that can be reused across your projects => helpers
// 
