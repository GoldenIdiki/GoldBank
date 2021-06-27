using GoldBankLite.Core.Implementation;
using GoldBankLite.Core.Interface;
using GoldBankLite.Core.IRepository;
using GoldBankLite.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GoldBankLite.UI_BankForms
{
    public partial class DashBoard : Form
    {
        private readonly IAccountServices _accountService;
        private readonly IAccountRepository _accountRepo;
        public DashBoard(IAccountServices accountService, IAccountRepository accountRepo)
        {
            InitializeComponent();
            _accountService = accountService;
            _accountRepo = accountRepo;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void DashBoard_Deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(_accountService, _accountRepo);
            deposit.Show();
        }

        private void DashBoard_Withdraw_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw(_accountService, _accountRepo);
            wd.Show();
        }

        private void DashBoard_Balance_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance(_accountRepo); 
            
            bal.Show();
        }

        private void DashBoard_Statement_Click(object sender, EventArgs e)
        {
            Statement stat = new Statement(_accountService, _accountRepo);
            stat.Show();
        }

        private void DashBoard_Transfer_Click(object sender, EventArgs e)
        {
            Transfer trans = new Transfer(_accountService,_accountRepo);
            trans.Show();
        }
    }
}
