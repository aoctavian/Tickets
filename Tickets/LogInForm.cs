using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets.Data;
using Tickets.Model;

namespace Tickets
{
    public partial class LogInForm : Form
    {
        public Account MyAccount { get; set; }
        IAccountRepository AccountsRepo { get; set; }

        public LogInForm()
        {
            InitializeComponent();
            AccountsRepo = new AccountRepository(new AppDbContext());
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            //TryLogIn();
        }

        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TryLogIn();
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            TryLogIn();
        }

        private void TryLogIn()
        {
            if (!string.IsNullOrEmpty(tbUser.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                loading.Visible = true;
                new Thread(() =>
                {
                    LogIn();
                }).Start();
            }
            else
            {
                MessageBox.Show("Please fill your credentials.", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LogIn()
        {
            Account dbAccount;
            if ((dbAccount = await AccountsRepo.IsAccountValidAsync(tbUser.Text, tbPassword.Text)) != null)
            {
                MyAccount = dbAccount;
                Console.WriteLine(MyAccount.Id);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                loading.Visible = false;
                tbUser.Focus();
                tbUser.SelectAll();
                MessageBox.Show("Incorrect user or password. Please try again.", "Invalid account", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
