using GoldBankLite.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace GoldBankLite.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> CustomerTbl { get; set; }
        public DbSet<Account> AccountTbl { get; set; }
        public DbSet<Transaction> TransactionTbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource=GoldBankLiteDB;");
        }
    }
}
