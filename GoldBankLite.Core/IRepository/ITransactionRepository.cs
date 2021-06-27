using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBankLite.Core.IRepository
{
    public interface ITransactionRepository
    {
        void DepositTransact(string accountNumber, decimal amount, string note = "deposit");

        void WithdrawTransact(string accountNumber, decimal amount, string note = "withdraw");

        void TransferDebit(string debitAccountNumber, decimal amount, string note = "transfer-debit");

        void TransferCredit(string creditAccountNumber, decimal amount, string note = "transfer-credit");
    }
}
