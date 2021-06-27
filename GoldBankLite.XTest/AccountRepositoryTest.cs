using GoldBankLite.Core.IRepository;
using GoldBankLite.Model;
using GoldBankLite.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GoldBankLite.XTest
{

    /// <summary>
    /// Testing the Account Repository class
    /// </summary>
    public class AccountRepositoryTest : DataContextBase
    {
        public IAccountRepository StartConfiguration()
        {
            GlobalConfig.AddInstance();
            return GlobalConfig._accountRepo;
        }

        public IAccountRepository StartConfiguration1()
        {
            GlobalConfig.AddInstance();
            return GlobalConfig._accountRepo;
        }

        /// <summary>
        /// Checking if the account exists in the database by checking the boolean return type
        /// </summary>

        [Fact]
        public void IsAccountExistsTest()
        {
            var custRepo = StartConfiguration();
            var acctRepo = StartConfiguration1();

            // arrange
            string RealAccount = "123";
            string FalseAccount = "026";

            //act

            // Return False
            var actualFalse = acctRepo.IsAccountExists(FalseAccount);

            // Return True
            var actualTrue = acctRepo.IsAccountExists(RealAccount);

            //assert

            // Return False
            Assert.False(actualFalse);

            // Return True
            Assert.True(actualTrue);

        }

        /// <summary>
        /// Checking for the account type of an account number 
        /// </summary>

        [Fact]
        public void GetAccountType()
        {
            var custRepo = StartConfiguration();
            var acctRepo = StartConfiguration1();

            // arrange
            string account = "123";
            var expected = "savings";

            //act

            var actual = acctRepo.GetAccountType(account);

            //assert

            Assert.Equal(expected, actual);

        }

        /// <summary>
        /// Checking the Get Account method by checking if the account balance is the same
        /// </summary>

        [Fact]
        public void GetAccount()
        {
            var custRepo = StartConfiguration();
            var acctRepo = StartConfiguration1();

            // arrange
            string account = "123";
            var expected = 5000;

            //act

            var actual1 = acctRepo.GetAccount(account);
            var actual = actual1.Balance;

            //assert

            Assert.Equal(expected, actual);

        }
    }
}
