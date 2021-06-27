using GoldBankLite.Data;
using GoldBankLite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoldBankLite.XTest
{
     public  class DataContextInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (context.TransactionTbl.Any())
            {
                return;
            }
            if (context.AccountTbl.Any())
            {
                return;
            }
            if (context.CustomerTbl.Any())
            {
                return;
            }

            Seed(context);
        }
        private static void Seed(DataContext context)
        {
            // Customers seed values
            var customers = new Customer[]
            {
                new Customer{Id = "abc", DateCreated = DateTime.Now, Email = "g@gmail.com", FirstName = "Gold", LastName = "Ezekiel", Password = "012", PhoneNumber = "0000"},
                new Customer{Id = "def", DateCreated = DateTime.Now, Email = "m@gmail.com", FirstName = "Mike", LastName = "Nwosu", Password = "345", PhoneNumber = "1111"},
                new Customer{Id = "ghi", DateCreated = DateTime.Now, Email = "k@gmail.com", FirstName = "Kufre", LastName = "Ita", Password = "678", PhoneNumber = "2222"},
            };
            context.AddRange(customers);
            context.SaveChanges();

            // Accounts seed values
            var accounts = new Account[]
            {
                new Account{Id = "mno", AccountNumber = "123", AccountType = "savings", Balance = 5000, CustomerId = "abc", DateCreated = DateTime.Now},
                new Account{Id = "pqr", AccountNumber = "456", AccountType = "current", Balance = 5000, CustomerId = "def", DateCreated = DateTime.Now},
                new Account{Id = "stu", AccountNumber = "789", AccountType = "current", Balance = 5000, CustomerId = "ghi", DateCreated = DateTime.Now},
            };
            context.AddRange(accounts);
            context.SaveChanges();

            // Transactions seed values
            var transactions = new Transaction[]
            {
             new Transaction{Id = "zxc", AccountId= "mno", Amount = 1000, TransactionDate = DateTime.Now, Note = "transfer_deposit", TransactionType = "Deposit"},
             new Transaction{Id = "vbn", AccountId= "pqr", Amount = 1000, TransactionDate = DateTime.Now, Note = "transfer_withdraw", TransactionType = "withdrwal"},
             new Transaction{Id = "asd", AccountId= "stu", Amount = 1000, TransactionDate = DateTime.Now, Note = "transfer_deposit", TransactionType = "Deposit"},
            };
            context.AddRange(transactions);
            context.SaveChanges();
            
            
        }
    }
   
}
