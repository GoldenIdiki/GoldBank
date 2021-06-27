using GoldBankLite.Core.Interface;
using GoldBankLite.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GoldBankLite.XTest
{
    /// <summary>
    /// Testing the Account Services class
    /// </summary>

    public class AccountServicesTests : DataContextBase
    {
        //public IAccountServices _accountService;
        public IAccountServices StartConfiguration()
        {
            GlobalConfig.AddInstance();
            return GlobalConfig._accountService;
        }

        /// <summary>
        /// Tests for Deposits
        /// </summary>

        [Fact]
        public void DepositTest()
        {
            var acctService = StartConfiguration();

            // arrange
            string falseAccount = "072";
            string accountNumber = "123";
            decimal amountLessThanZero = -12;
            decimal amountEqualZero = 0;
            decimal amountMoreThanZero = 12;
            string note = "transfer";

            //act

            // Return False
            var depositFalseAccount = acctService.Deposit(falseAccount, amountMoreThanZero, note);
            var depositLessThanZero = acctService.Deposit(accountNumber, amountLessThanZero, note);
            var depositEqualZero = acctService.Deposit(accountNumber, amountEqualZero, note);

            // Return True
            var depositTrue = acctService.Deposit(accountNumber, amountMoreThanZero, note);

            //assert
            Assert.False(depositFalseAccount);
            Assert.False(depositLessThanZero);
            Assert.False(depositEqualZero);

            Assert.True(depositTrue);
        }

        /// <summary>
        /// Tests for Withdrawal
        /// </summary>

        [Fact]
        public void WithdrawalTests()
        {
            var acctService = StartConfiguration();

            //arrange
            //string accountNumber = "123";
            string debitAccountSavings = "123";

            //string accountNumberTwo = "123";
            string accountCurrent = "456";
            string falseAccount = "059";
            decimal amount = 10;
            //decimal amountTwo = 450;
            //decimal amountThree = 2050;
            decimal amountSavingsFail = 4500;
            decimal amountCurrentFail = 45000;
            decimal amountCurrentPass = 5000;
            decimal amountSavingsPass = 4000;
            string note = "";

            //act

            // Return False
            var withdrawFalseAccount = acctService.Withdrawal(falseAccount, amount, note);
            var withdrawSavingsFalse = acctService.Withdrawal(debitAccountSavings, amountSavingsFail, note);
            var withdrawCurrentFalse = acctService.Withdrawal(accountCurrent, amountCurrentFail, note);

            // Return True
            var withdrawSavingsTrue = acctService.Withdrawal(debitAccountSavings, amountSavingsPass, note);
            var withdrawCurrentTrue = acctService.Withdrawal(accountCurrent, amountCurrentPass, note);


            //assert

            Assert.False(withdrawFalseAccount);
            Assert.False(withdrawSavingsFalse);
            Assert.False(withdrawCurrentFalse);

            Assert.True(withdrawSavingsTrue);
            Assert.True(withdrawCurrentTrue);
        }

        /// <summary>
        /// Tests for Transfers
        /// </summary>

        [Fact]
        public void TransferTest()
        {
            var acctService = StartConfiguration();
            //arrange
            string debitAccountCurrent1 = "456";
            string debitAccountCurrent2 = "789";
            string debitAccountSavings = "123";
            string creditAccountCurrent = "456";
            string falseAccount = "945";
            decimal amount = 345;
            decimal amountPass = 500;
            decimal amountSavingsFail = 15000;
            decimal amountCurrentFail = 50000;
            decimal amountCurrentPass = 2000;
            string note = "";

            //act

            // Return False
            var transferFalseAccount = acctService.Transfer(debitAccountSavings, falseAccount, amount, note);
            var transferCurrentFail = acctService.Transfer(debitAccountCurrent1, debitAccountSavings, amountCurrentFail, note);
            var transferSavingsFail = acctService.Transfer(debitAccountSavings, creditAccountCurrent, amountSavingsFail, note);
            var transferSelf = acctService.Transfer(debitAccountSavings, debitAccountSavings, amountPass, note);

            // Return True
            var transferCurrentTrue = acctService.Transfer(debitAccountCurrent1, debitAccountCurrent2, amountCurrentPass, note);

            var transferSavingsTrue = acctService.Transfer(debitAccountSavings, creditAccountCurrent, amountPass, note);



            //assert
            Assert.False(transferFalseAccount);
            Assert.False(transferCurrentFail);
            Assert.False(transferSavingsFail);
            Assert.False(transferSelf);

            Assert.True(transferCurrentTrue);
            Assert.True(transferSavingsTrue);
        }

        [Fact]
        public void GetBalanceTest()
        {
            var acctService = StartConfiguration();

            // arrange
            string accountNumber = "123";
            decimal amountMoreThanZero = 1000;
            string note = "transfer";
            string accountNumberSame = "123";
            decimal amountMore = 1000;
            string noteSame = "transfer";

            var expected = 7000;

            //act

            // Return True
            var depositTrue = acctService.Deposit(accountNumber, amountMoreThanZero, note);
            var depositTrueSame = acctService.Deposit(accountNumberSame, amountMore, noteSame);

            var actual = acctService.GetBalance(accountNumber);

            //assert
            Assert.Equal(expected, actual);
        }

    }
}
