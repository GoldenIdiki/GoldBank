using GoldBankLite.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBankLite.Core.IRepository
{
    public interface ICustomerRepository
    {
        bool IsCustomerExists(string email);

        void CreateCustomer(string firstName, string lastName, string email, string phoneNumber, string password, string accountType);

        Customer GetCustomerByEmail(string email);

        void UpdateCustomer(string email);

        void DeleteCustomer(string email);
    }
}
