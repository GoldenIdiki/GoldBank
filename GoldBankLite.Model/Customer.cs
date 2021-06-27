using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoldBankLite.Model
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid().ToString();

            DateCreated = DateTime.Now;

            Accounts = new List<Account>();
        }

        [Key]
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public List<Account> Accounts { get; set; }

    }
}
