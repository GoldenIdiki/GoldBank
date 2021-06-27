using GoldBankLite.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBankLite.Core.Interface
{
    public interface IAuthServices
    {
        Customer Login(string email, string password);

        void Logout();
    }
}
