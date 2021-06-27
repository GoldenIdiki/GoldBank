using GoldBankLite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldBankLite.BankForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfig.AddInstance();


            Application.Run(new Registration(GlobalConfig._customerRepo, GlobalConfig._authService, GlobalConfig._accountService, GlobalConfig._accountRepo));


        }
    }
}
