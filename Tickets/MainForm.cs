using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class MainForm : Form
    {
        public int Id { get; set; }
        public string User { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogInDialogShow();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LogInDialogShow();
        }

        private void EnableFormData()
        {
            layoutPanel.Visible = true;
        }

        private void LogInDialogShow()
        {
            using (var LIF = new LogInForm())
            {
                if (LIF.ShowDialog() == DialogResult.OK)
                {
                    Id = LIF.Id;
                    User = LIF.User;
                    EnableFormData();
                    ShowTickets(Id);
                }
            }
        }

        private async void ShowTickets(int userId)
        {
            SqlConnection connection = new SqlConnection("Data Source=OCTAVIAN;Initial Catalog=Tickets;Integrated Security=True;");
            try
            {
                await connection.OpenAsync();
            }
            catch
            {
                MessageBox.Show("Cannot connect to database", "Database down", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command = new SqlCommand($"select * from [Ticket] t join (select [IdTicket] from [UserTickets] where [IdUser]='{userId}') ut on ut.IdTicket = t.Id where [ClosedAt] is null", connection);
            SqlDataReader dr = await command.ExecuteReaderAsync();
            int i=1;
            while (dr.Read())
            {
                Ticket ticket = new Ticket()
                {
                    Id = Convert.ToInt32(dr[0]),
                    Subject = dr[1].ToString(),
                    Description = dr[2].ToString(),
                    Status = dr[3].ToString(),
                    Type = dr[4].ToString(),
                    ServiceType = dr[5].ToString(),
                    Priority = dr[6].ToString(),
                    CustomerName = dr[7].ToString(),
                    CreatedAt = DateTime.Parse(dr[8].ToString())
                };
                TicketControl ticketControl = new TicketControl(ticket)
                {
                    Dock = DockStyle.Top
                };

                layoutPanel.RowCount++;
                RowStyle rs = new RowStyle(SizeType.AutoSize);
                layoutPanel.RowStyles.Add(rs);
                layoutPanel.Controls.Add(ticketControl, 0, layoutPanel.RowCount - 1);

                Console.WriteLine("++");
            }
        }
    }
}
