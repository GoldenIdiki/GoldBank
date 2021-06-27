using GoldBankLite.Common;
using GoldBankLite.Core.Interface;
using GoldBankLite.Core.IRepository;
using GoldBankLite.Core.Repository;
using GoldBankLite.Data;
using GoldBankLite.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldBankLite.Core.Implementation
{
    public class AccountServices : IAccountServices
    {
        private readonly DataContext _dbContext;
        private readonly IAccountRepository _accountRepo;
        private readonly ITransactionRepository _transactRepo;
        public AccountServices(DataContext dbContext, IAccountRepository accountRepo, ITransactionRepository transactRepo)
        {
            _dbContext = dbContext;
            _accountRepo = accountRepo;
            _transactRepo = transactRepo;
        }

        // Deposit Fund
        public bool Deposit(string accountNumber, decimal amount, string note = "deposit")
        {
            if (!(_accountRepo.IsAccountExists(accountNumber)))
            {
               return false;
            }

            if (amount <= 0)
            {
                return false;
            }
            else
            {
                _accountRepo.GetAccount(accountNumber).Balance += amount;

                _transactRepo.DepositTransact(accountNumber, amount, "deposit");

                return true;
            }   
        }

        // Get balance
        public decimal GetBalance(string accountNumber)
        {
            if (!(_accountRepo.IsAccountExists(accountNumber)))
            {
                throw new NullReferenceException("Account number does not exist.");
            }

            return _accountRepo.GetAccount(accountNumber).Balance;
        }

        // Get Account Statement
        public List<Transaction> GetStatementOfAccount(string accountNumber)
        {
            if (!(_accountRepo.IsAccountExists(accountNumber)))
            {
                throw new NullReferenceException("Account number does not exist.");
            }

            var account = _dbContext.AccountTbl.Include(x => x.Transactions).FirstOrDefault(x => x.AccountNumber == accountNumber);
            var transaction = _dbContext.AccountTbl.Include(x => x.Transactions).FirstOrDefault(x => x.AccountNumber == accountNumber).Transactions;
            //var transactions = _dbContext.TransactionTbl.Where(x => x.AccountId == account.Id).ToList();

            return transaction;
        }

        // Transfer Fund
        public bool Transfer(string debitAccountNumber, string creditAccountNumber, decimal amount, string note = "transfer")
        {
            var debitAccount = _accountRepo.GetAccount(debitAccountNumber);

            if (!(_accountRepo.IsAccountExists(creditAccountNumber)))
            {
                return false;
            }

            if (debitAccountNumber == creditAccountNumber)
            {
                return false;
            }

            if ((debitAccount.AccountType == "current") && (debitAccount.Balance < amount))
            {
                return false;
            }

            if ((debitAccount.AccountType == "savings") && (debitAccount.Balance - amount < Helpers.MinimumBalanceSavings()))
            {
                return false;
            }

            _accountRepo.GetAccount(debitAccountNumber).Balance -= amount;
            _accountRepo.GetAccount(creditAccountNumber).Balance += amount;

            _transactRepo.TransferDebit(debitAccountNumber, amount, "transfer-debit");
            _transactRepo.TransferCredit(creditAccountNumber, amount, "transfer-credit");

            return true;

        }

        // Withdraw Fund
        public bool Withdrawal(string accountNumber, decimal amount, string note = "withdraw")
        {
            if (!(_accountRepo.IsAccountExists(accountNumber)))
            {
                return false;
            }
            if (_accountRepo.GetAccountType(accountNumber) == "savings")
            {
                if (GetBalance(accountNumber) - amount < Helpers.MinimumBalanceSavings())
                {
                    return false;
                }
                else
                {
                    _accountRepo.GetAccount(accountNumber).Balance -= amount;
                    _transactRepo.WithdrawTransact(accountNumber, amount, note);
                    return true;
                }
            }
            else
            {
                if (GetBalance(accountNumber) - amount < Helpers.MinimumBalanceCurrent())
                {
                    return false;
                }
                else
                {
                    _accountRepo.GetAccount(accountNumber).Balance -= amount;
                    _transactRepo.WithdrawTransact(accountNumber, amount, note);
                    return true;
                }
            }
        }
    }
}
