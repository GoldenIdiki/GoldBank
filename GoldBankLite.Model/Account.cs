using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GoldBankLite.Model
{
    public class Account
    {
        public Account()
        {
            Id = Guid.NewGuid().ToString();

            var result = Id.Where(x => char.IsDigit(x)).Take(10).ToList();
            AccountNumber = string.Join("", result);

            DateCreated = DateTime.Now;

            Transactions = new List<Transaction>();
        }

        [Key]
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
}
