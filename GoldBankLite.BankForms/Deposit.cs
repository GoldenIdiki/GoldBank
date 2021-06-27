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
    public partial class Deposit : Form
    {
        private readonly IAccountServices _accountService;
        private readonly IAccountRepository _accountRepo;
        public Deposit(IAccountServices accountService, IAccountRepository accountRepo)
        {
            InitializeComponent();
            _accountService = accountService;
            _accountRepo = accountRepo;
        }

        private void Deposit_Button_Click(object sender, EventArgs e)
        {
            var account = _accountRepo.GetAccountNow(AuthServices.CurrentCustomer.Email);
            var initialBalance = account.Balance;

            var depositAmount = Convert.ToDecimal(Deposit_Amount_Field.Text);
            var note = Deposit_Note_Field.Text;

            _accountService.Deposit(account.AccountNumber, depositAmount, note);

            var newBalance = account.Balance;

            if (newBalance > initialBalance)
            {
                MessageBox.Show("Deposit Successful", "Transaction Successful!!!", MessageBoxButtons.OK);
                DashBoard db = new DashBoard(_accountService, _accountRepo);
                db.Show();
            }
        }        
    }
}
