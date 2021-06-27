using GoldBankLite.Common;
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
    public partial class Login : Form
    {
        private readonly IAuthServices _authService;
        private readonly IAccountServices _accountService;
        private readonly IAccountRepository _accountRepo;
        public Login(IAuthServices authService, IAccountServices accountService, IAccountRepository accountRepo)
        {
            InitializeComponent();
            _authService = authService;
            _accountService = accountService;
            _accountRepo = accountRepo;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            var email = Login_Email_Field.Text;
            var password = Login_Password_Field.Text;
            
            _authService.Login(email, password);
            //var v =AuthServices.CurrentCustomer 

            DashBoard db = new DashBoard(_accountService, _accountRepo);
            db.Show();
        }
    }
}
