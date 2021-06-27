using GoldBankLite.Core.Implementation;
using GoldBankLite.Core.Interface;
using GoldBankLite.Core.IRepository;
using GoldBankLite.Data;
using GoldBankLite.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoldBankLite.Core.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _dbContext;
        public AccountRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }


        public void CreateAccount(string accountType)
        {
            Account account = new Account()
            {
                CustomerId = AuthServices.CurrentCustomer.Id,
                AccountType = accountType
            };
        }

        public void DeleteAccount()
        {
            throw new NotImplementedException();
        }

        public bool IsAccountExists(string accountNumber)
        {
            return _dbContext.AccountTbl.Any(x => x.AccountNumber == accountNumber);
        }

        public string GetAccountType(string accountNumber)
        {
            return _dbContext.AccountTbl.FirstOrDefault(x => x.AccountNumber == accountNumber).AccountType;
        }
        
        public Account GetAccount(string accountNumber)
        {
            return _dbContext.AccountTbl.FirstOrDefault(x => x.AccountNumber == accountNumber);
        }

        public Account GetAccount(Customer customer)
        {
            return _dbContext.AccountTbl.FirstOrDefault(x => x.Customer == customer);
        }

        public Account GetAccountNow(string email)
        {
            return _dbContext.AccountTbl.Include(x => x.Customer).FirstOrDefault(x => x.Customer.Email == email);
        }
    }
}
