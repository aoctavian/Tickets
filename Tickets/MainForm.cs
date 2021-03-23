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
using Tickets.Data;
using Tickets.Model;

namespace Tickets
{
    public partial class MainForm : Form
    {
        public static Account MyAccount { get; set; }
        List<Ticket> TicketsList { get; set; }
        ITicketRepository TicketsRepo { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            TicketsRepo = new TicketRepository(new AppDbContext());
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
            panelTickets.Visible = true;
            toolStrip.Visible = true;
        }

        private async void LogInDialogShow()
        {
            using (var LIF = new LogInForm())
            {
                if (LIF.ShowDialog() == DialogResult.OK)
                {
                    MyAccount = LIF.MyAccount;
                    EnableFormData();
                    await ReadTickets(MyAccount.Id);
                    ShowTickets(TicketsList.FindAll(t => t.ClosedAt == null));
                }
            }
        }

        private async Task ReadTickets(int userId)
        {
            TicketsList = await TicketsRepo.GetAllTicketsForUserAsync(userId);
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
                        AddTicketPanel(ticket);
                    }
                }));
            }).Start();
        }

        private void AddTicketPanel(Ticket ticket)
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
                    TicketsList.Insert(0, TF.Ticket);
                    if (btnShowAll.Checked || btnShowOpened.Checked)
                        InsertTicketPanelAt0(TF.Ticket);
                }
            }
        }
    }
}
