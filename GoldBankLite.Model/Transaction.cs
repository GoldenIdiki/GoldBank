using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GoldBankLite.Model
{
    public class Transaction
    {
        public Transaction()
        {
            Id = Guid.NewGuid().ToString();

            TransactionDate = DateTime.Now;
        }
        [Key]
        public string Id { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Note { get; set; }
        public string AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
    }
}
