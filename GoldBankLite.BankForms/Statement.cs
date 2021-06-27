using GoldBankLite.Core.Implementation;
using GoldBankLite.Core.Interface;
using GoldBankLite.Core.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoldBankLite.UI_BankForms
{
    public partial class Statement : Form
    {
        private readonly IAccountServices _accountService;
        private readonly IAccountRepository _accountRepo;
        public Statement(IAccountServices accountService, IAccountRepository accountRepo)
        {
            InitializeComponent();

            _accountService = accountService;
            _accountRepo = accountRepo;
        }

        private void Statement_Load(object sender, EventArgs e)
        {
            var account = _accountRepo.GetAccountNow(AuthServices.CurrentCustomer.Email);
            var transactions = _accountService.GetStatementOfAccount(account.AccountNumber);
            TransactHist.DataSource = transactions.Select(x => new
            {
                TransactionId = x.Id,
                Date = x.TransactionDate.ToString(),
                Amount = x.Amount.ToString(),
                Note = x.Note,
                TransactionType = x.TransactionType
            }).ToList();
        }
    }
}
