using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class MainForm : Form
    {
        public int Id { get; set; }
        public string User { get; set; }
        List<Ticket> TicketsList { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
            toolStrip.Visible = true;
        }

        private async void LogInDialogShow()
        {
            using (var LIF = new LogInForm())
            {
                if (LIF.ShowDialog() == DialogResult.OK)
                {
                    Id = LIF.Id;
                    User = LIF.User;
                    EnableFormData();
                    await ReadTickets(Id);
                    ShowTickets(TicketsList.FindAll(t => t.ClosedAt == null));
                }
            }
        }

        private async Task ReadTickets(int userId)
        {
            TicketsList = new List<Ticket>();

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
            SqlCommand command = new SqlCommand($"select * from [Ticket] t join (select [IdTicket] from [UserTickets] where [IdUser]='{userId}') ut on ut.IdTicket = t.Id order by [CreatedAt] desc", connection);
            SqlDataReader dr = await command.ExecuteReaderAsync();

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
                if (dr[9].ToString() == "")
                    ticket.ClosedAt = null;
                else
                    ticket.ClosedAt = DateTime.Parse(dr[9].ToString());
                TicketsList.Add(ticket);
            }
        }

        private void ShowTickets(List<Ticket> TicketsList)
        {
            new Thread(() =>
            {
                this.BeginInvoke(new MethodInvoker(delegate ()
                {
                    layoutPanel.Controls.Clear();

                    foreach (var ticket in TicketsList)
                    {
                        ShowTicketPanel(ticket);
                    }
                }));
            }).Start();
        }

        private void ShowTicketPanel(Ticket ticket)
        {
            TicketControl ticketControl = new TicketControl(ticket)
            {
                Dock = DockStyle.Top
            };
            layoutPanel.RowCount++;
            RowStyle rs = new RowStyle(SizeType.AutoSize);
            layoutPanel.RowStyles.Add(rs);
            layoutPanel.Controls.Add(ticketControl, 0, layoutPanel.RowCount - 1);
        }

        private void InsertTicketPanelAt0(Ticket ticket)
        {
            TicketControl ticketControl = new TicketControl(ticket)
            {
                Dock = DockStyle.Top
            };
            layoutPanel.RowCount++;
            RowStyle rs = new RowStyle(SizeType.AutoSize);
            layoutPanel.RowStyles.Insert(1, rs);
            layoutPanel.Controls.Add(ticketControl, 0, 1);
        }

        private void ViewTickets_Click(object sender, EventArgs e)
        {
            btnShowAll.Checked = btnShowOpened.Checked = btnShowClosed.Checked = false;
            ToolStripButton btnClicked = (ToolStripButton)sender;
            btnClicked.Checked = true;

            if (btnShowAll.Checked)
                ShowTickets(TicketsList);
            else if (btnShowOpened.Checked)
                ShowTickets(TicketsList.FindAll(t => t.ClosedAt == null));
            else if (btnShowClosed.Checked)
                ShowTickets(TicketsList.FindAll(t => t.ClosedAt != null));
        }

        private void BtnCreateTicket_Click(object sender, EventArgs e)
        {
            using (var TF = new TicketForm())
            {
                if (TF.ShowDialog() == DialogResult.OK)
                {
                    Ticket ticket = TF.Ticket;
                    TicketsList.Insert(0, ticket);
                    if (btnShowAll.Checked || btnShowOpened.Checked)
                        InsertTicketPanelAt0(ticket);
                }
            }
        }
    }
}
