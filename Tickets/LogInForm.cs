using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class LogInForm : Form
    {
        public int Id { get; set; }
        public string User { get; set; }

        public LogInForm()
        {
            InitializeComponent();
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
                LogIn();
            }
            else
            {
                MessageBox.Show("Please fill your credentials.", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LogIn()
        {
            loading.Visible = true;
            SqlConnection connection = new SqlConnection("Data Source=OCTAVIAN;Initial Catalog=Tickets;Integrated Security=True;");
            try
            {
                await connection.OpenAsync();
            }
            catch
            {
                loading.Visible = false;
                MessageBox.Show("Cannot connect to database", "Database down", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command = new SqlCommand($"select * from [account] where [User]='{tbUser.Text}' and [Password] = '{tbPassword.Text}'", connection);
            SqlDataReader dr = await command.ExecuteReaderAsync();
            if (dr.Read())
            {
                Id = Convert.ToInt32(dr[0]);
                User = dr[4].ToString();
                dr.Close();

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                loading.Visible = false;
                MessageBox.Show("Incorrect user or password. Please try again.", "Invalid account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUser.Focus();
                tbUser.SelectAll();
            }
            connection.Close();
        }
    }
}
