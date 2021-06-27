using GoldBankLite.Core.IRepository;
using GoldBankLite.Data;
using GoldBankLite.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using GoldBankLite.Common;

namespace GoldBankLite.Core.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dbContext;

        public CustomerRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        //Check if customer Exists
        public bool IsCustomerExists(string email)
        {
            return _dbContext.CustomerTbl.Any(e => e.Email == email);
        }
        // Save Customer and Account during registration
        public void CreateCustomer(string firstName, string lastName, string email, string phoneNumber, string password, string accountType)
        {
            Account account = new Account()
            {
                AccountType = accountType
            };
            Customer customer = new Customer()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                Password = password,
                PasswordHash = Convert.ToBase64String(Utilities.GenerateHash(password)[0]),
                PasswordSalt = Convert.ToBase64String(Utilities.GenerateHash(password)[1])
            };
            customer.Accounts.Add(account);
            _dbContext.CustomerTbl.Add(customer);
            _dbContext.SaveChanges();
        }

        // Get a particular customer by email 
        public Customer GetCustomerByEmail(string email)
        {
            return _dbContext.CustomerTbl.FirstOrDefault(x => x.Email == email);
        }

        public void DeleteCustomer(string email)
        {
            //throw new NotImplementedException();
        }

       

        public void UpdateCustomer(string email)
        {
            //throw new NotImplementedException();
        }
    }
}
