using GoldBankLite.Core.IRepository;
using GoldBankLite.Model;
using GoldBankLite.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GoldBankLite.XTest
{
    public class CustomerRepositoryTest : DataContextBase
    {
        /// <summary>
        /// Testing the Customer Repository class
        /// </summary>
        /// <returns></returns>

        public ICustomerRepository StartConfiguration()
        {
            GlobalConfig.AddInstance();
            return GlobalConfig._customerRepo;
        }

        public IAccountRepository StartConfiguration1()
        {
            GlobalConfig.AddInstance();
            return GlobalConfig._accountRepo;
        }

        /// <summary>
        /// Testing the Create Customer method by checking the length of the account number generated
        /// </summary>

        [Fact]
        public void CreateCustomerTest()
        {
            var custRepo = StartConfiguration();
            var acctRepo = StartConfiguration1();

            // arrange
            custRepo.CreateCustomer("Kenneth", "Hagin", "hagin@gmail.com", "08097563872", "345276", "current");
            var expected = 10;

            //act
            var actual = acctRepo.GetAccountNow("hagin@gmail.com").AccountNumber.Length;

            //assert
            Assert.Equal(expected, actual);
            
        }

        /// <summary>
        /// Testing the Is Customer Exists method by checking if the return type is true or false
        /// </summary>

        [Fact]
        public void IsCustomerExistsTest()
        {
            var custRepo = StartConfiguration();

            // arrange
            string RealEmail = "g@gmail.com";
            string FalseEmail = "z@gmail.com";

            //var expectedFalse = false;
            //var expectedTrue = true;

            //act

            // Return False
            var actualFalse = custRepo.IsCustomerExists(FalseEmail);

            // Return True
            var actualTrue = custRepo.IsCustomerExists(RealEmail);

            //assert

            // Return False
            Assert.False(actualFalse);

            // Return True
            Assert.True(actualTrue);

        }


        /// <summary>
        /// Testing the Get Customer by email method by checking the Full name of the customer in the database
        /// </summary>

        [Fact]
        public void GetCustomerByEmailTest()
        {
            var custRepo = StartConfiguration();

            // arrange
            string email = "g@gmail.com";
            var customer = custRepo.GetCustomerByEmail(email);
            var expected = "Gold Ezekiel";

            //act
            
            var actual = customer.FirstName + " " + customer.LastName;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
