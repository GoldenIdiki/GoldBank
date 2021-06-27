using GoldBankLite.Common;
using GoldBankLite.Core.Interface;
using GoldBankLite.Core.IRepository;
using GoldBankLite.UI_BankForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldBankLite.BankForms
{
    public partial class Registration : Form
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IAuthServices _authService;
        private readonly IAccountServices _accountService;
        private readonly IAccountRepository _accountRepo;
        public Registration(ICustomerRepository customerRepo, IAuthServices authService, IAccountServices accountService, IAccountRepository accountRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _authService = authService;
            _accountService = accountService;
            _accountRepo = accountRepo;
        }

        private void Register_Submit_Click(object sender, EventArgs e)
        {
            var cleanFirstName = Utilities.Sanitize(Register_FirstName_Field.Text);
            var cleanLastName = Utilities.Sanitize(Register_LastName_Field.Text);
            var emailCheck = Utilities.IsEmailValid(Register_Email_Field.Text);

            if (!emailCheck)
            {
                Register_Email_Field.BackColor = Color.Red;
                MessageBox.Show("Email is not valid", "Invalid Email", MessageBoxButtons.OK);
            }

            if (Register_Savings_Field.Checked)
            {
               _customerRepo.CreateCustomer(cleanFirstName, cleanLastName, Register_Email_Field.Text, Register_PhoneNumber_Field.Text, Register_Password_Field.Text, "savings");

                Login login = new Login(_authService, _accountService, _accountRepo);
                login.Show();
            }
            else if (Register_Current.Checked)
            {
                _customerRepo.CreateCustomer(Register_FirstName_Field.Text, Register_LastName_Field.Text, Register_Email_Field.Text, Register_PhoneNumber_Field.Text, Register_Password_Field.Text, "current");

                Login login = new Login(_authService, _accountService, _accountRepo);
                login.Show();
            }
        }

        private void Register_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login(_authService, _accountService, _accountRepo);
            login.Show();
        }
    }
}
