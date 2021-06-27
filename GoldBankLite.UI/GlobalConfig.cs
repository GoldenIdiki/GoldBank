using GoldBankLite.Core.Implementation;
using GoldBankLite.Core.Interface;
using GoldBankLite.Core.IRepository;
using GoldBankLite.Core.Repository;
using GoldBankLite.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBankLite.UI
{
    public static class GlobalConfig
    {
        private static DataContext _dataContext = new DataContext();

        public static ICustomerRepository _customerRepo;
        public static IAccountRepository _accountRepo;
        public static ITransactionRepository _transactRepo;
        public static IAccountServices _accountService;

        public static IAuthServices _authService;
    

        public static void AddInstance()
        {
            _accountRepo = new AccountRepository(_dataContext);
            _transactRepo = new TransactionRepository(_dataContext, _accountRepo);
            _customerRepo = new CustomerRepository(_dataContext);
        
            _accountService = new AccountServices(_dataContext, _accountRepo, _transactRepo);
            _authService = new AuthServices(_customerRepo);
        }

        public static void RemoveInstance()
        {
            _customerRepo = null;
            _accountRepo = null;
            _authService = null;
        }
    }
}
