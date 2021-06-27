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
    public partial class Transfer : Form
    {
        private readonly IAccountServices _accountService;
        private readonly IAccountRepository _accountRepo;
        public Transfer(IAccountServices accountService, IAccountRepository accountRepo)
        {
            InitializeComponent();
            _accountService = accountService;
            _accountRepo = accountRepo;
        }

        private void Transfer_Button_Click(object sender, EventArgs e)
        {
            var account = _accountRepo.GetAccountNow(AuthServices.CurrentCustomer.Email);
            var accountTo = Transfer_CreditAccount_Field.Text;
            var initialBalance = account.Balance;

            var depositAmount = Convert.ToDecimal(Transfer_Amount_Field.Text);
            var note = Transfer_Note_Field.Text;

            _accountService.Transfer(account.AccountNumber,accountTo, depositAmount, note);

            var newBalance = account.Balance;

            if (newBalance < initialBalance)
            {
                MessageBox.Show("Transfer Successful", "Transaction Successful!!!", MessageBoxButtons.OK);
                DashBoard db = new DashBoard(_accountService, _accountRepo);
                db.Show();
            }
            else
            {
                MessageBox.Show("Transfer was not successful", "Unsuccessful Transaction", MessageBoxButtons.OK);
            }

        }
    }
}
