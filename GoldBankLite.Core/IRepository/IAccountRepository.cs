using GoldBankLite.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBankLite.Core.IRepository
{
    public interface IAccountRepository
    {
        void CreateAccount(string accountType);

        void DeleteAccount();

        bool IsAccountExists(string accountNumber);

        Account GetAccount(string accountNumber);

        string GetAccountType(string accountNumber);

        Account GetAccount(Customer customer);

        Account GetAccountNow(string email);
    }
}
