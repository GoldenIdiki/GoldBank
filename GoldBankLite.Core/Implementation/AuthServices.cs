using GoldBankLite.Common;
using GoldBankLite.Core.Interface;
using GoldBankLite.Core.IRepository;
using GoldBankLite.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBankLite.Core.Implementation
{
    public class AuthServices : IAuthServices
    {
        private readonly ICustomerRepository _customerRepo;
        public static Customer CurrentCustomer = null;
        public AuthServices(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public Customer Login(string email, string password)
        {
            if (!(_customerRepo.IsCustomerExists(email)))
            {
                throw new NullReferenceException("Email does not exist");
            }
            else
            {
                //if (Utilities.CompareHash(Convert.FromBase64String(_customerRepo.GetCustomerByEmail(email).PasswordSalt), Convert.FromBase64String(_customerRepo.GetCustomerByEmail(email).PasswordHash), password))
                //{
                if (_customerRepo.GetCustomerByEmail(email).Password == password)
                {
                    Customer customer = _customerRepo.GetCustomerByEmail(email);
                    CurrentCustomer = customer;
                    return customer;
                }
            }
            return null;
        }

        public void Logout()
        {
            CurrentCustomer = null;
        }
    }
}
