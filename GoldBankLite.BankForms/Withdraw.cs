using GoldBankLite.Core.Implementation;
using GoldBankLite.Core.Interface;
using GoldBankLite.Core.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GoldBankLite.UI_BankForms
{
    public partial class Withdraw : Form
    {
        private readonly IAccountServices _accountService;
        private readonly IAccountRepository _accountRepo;
        
        public Withdraw(IAccountServices accountService, IAccountRepository accountRepo)
        {
            InitializeComponent();
            _accountService = accountService;
            _accountRepo = accountRepo;
        }

        private void Withdraw_Button_Click(object sender, EventArgs e)
        {
            var accountNumber = Withdraw_AccountNumber_Field.Text;
            var amount = Convert.ToDecimal(Withdraw_Amount_Field.Text);
            var note = Withdraw_Note_Field.Text;

            var account = _accountRepo.GetAccountNow(AuthServices.CurrentCustomer.Email);
            var initialBalance = account.Balance;

            _accountService.Withdrawal(accountNumber, amount, note);

            var newBalance = account.Balance;

            if (newBalance < initialBalance)
            {
                MessageBox.Show("Withdraw Successful", "Transaction Successful!!!", MessageBoxButtons.OK);
                DashBoard db = new DashBoard(_accountService, _accountRepo);
                db.Show();
            }
        }
    }
}
