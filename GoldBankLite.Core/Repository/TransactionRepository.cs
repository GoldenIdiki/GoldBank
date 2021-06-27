using GoldBankLite.Core.IRepository;
using GoldBankLite.Data;
using GoldBankLite.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBankLite.Core.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DataContext _dbContext;
        private readonly IAccountRepository _accountRepo;
        public TransactionRepository(DataContext dbContext, IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
            _dbContext = dbContext;
        }

        public void DepositTransact(string accountNumber, decimal amount, string note = "deposit")
        {
            var account = _accountRepo.GetAccount(accountNumber);
            Transaction transact = new Transaction()
            {
                AccountId = account.Id,
                TransactionType = "deposit",
                Amount = amount,
                Note = note
            };
            account.Transactions.Add(transact);
            //_dbContext.TransactionTbl.Add(transact);
            _dbContext.SaveChanges();
        }

        public void TransferDebit(string debitAccountNumber, decimal amount, string note = "transfer-debit")
        {
            Transaction transact = new Transaction()
            {
                AccountId = _accountRepo.GetAccount(debitAccountNumber).Id,
                TransactionType = "transfer-debit",
                Amount = amount,
                Note = note
            };
            _dbContext.TransactionTbl.Add(transact);
            _dbContext.SaveChanges();
        }

        public void TransferCredit(string creditAccountNumber, decimal amount, string note = "transfer-credit")
        {
            Transaction transact = new Transaction()
            {
                AccountId = _accountRepo.GetAccount(creditAccountNumber).Id,
                TransactionType = "transfer-credit",
                Amount = amount,
                Note = note
            };
            _dbContext.TransactionTbl.Add(transact);
            _dbContext.SaveChanges();
        }

        public void WithdrawTransact(string accountNumber, decimal amount, string note = "withdraw")
        {
            Transaction transact = new Transaction()
            {
                TransactionType = "withdrawal",
                Amount = amount,
                Note = note,
                AccountId = _accountRepo.GetAccount(accountNumber).Id
            };
            _dbContext.TransactionTbl.Add(transact);
            _dbContext.SaveChanges();
        }
    }
}
