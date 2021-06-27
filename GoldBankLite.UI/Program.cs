using GoldBankLite.Core.IRepository;
using System;

namespace GoldBankLite.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.AddInstance();
            ICustomerRepository _custoRepo = GlobalConfig._customerRepo;
            
            Console.WriteLine("Hello World!");
        }
    }
}
