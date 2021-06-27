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
    public partial class Balance : Form
    {
        private readonly IAccountRepository _accountRepo;
        public Balance(IAccountRepository accountRepo)
        {
            InitializeComponent();
            _accountRepo = accountRepo;
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            var account = _accountRepo.GetAccountNow(AuthServices.CurrentCustomer.Email);
            Balance_ShowBalance.Text = account.Balance.ToString();
        }
    }
}
