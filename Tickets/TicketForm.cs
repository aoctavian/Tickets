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
using Tickets.Data;
using Tickets.Model;

namespace Tickets
{
    public partial class TicketForm : Form
    {
        private const int NEW_TICKET = 0, EDIT_TICKET = 1;
        private int FormType { get; set; }

        TicketControl TicketControl { get; set; }
        public Ticket Ticket { get; set; }

        ITicketRepository TicketsRepo;

        public TicketForm(TicketControl ticketControl) //edit ticket constructor
        {
            InitializeComponent();
            TicketsRepo = new TicketRepository(new AppDbContext());

            TicketControl = ticketControl;
            LoadForEditing(ticketControl);
        }

        public TicketForm() //new ticket constructor
        {
            InitializeComponent();
            TicketsRepo = new TicketRepository(new AppDbContext());

            LoadForNewTicket();
        }

        private void LoadForEditing(TicketControl ticketControl)
        {
            FormType = EDIT_TICKET;

            rtbSubject.Text = TicketControl.Ticket.Subject;
            rtbDescription.Text = TicketControl.Ticket.Description;
            cbStatus.Text = TicketControl.Ticket.Status;
            cbStatus.Enabled = false;
            cbType.Text = TicketControl.Ticket.Type;
            cbType.Enabled = false;
            cbServiceType.Text = TicketControl.Ticket.ServiceType;
            cbServiceType.Enabled = false;
            cbPriority.Text = TicketControl.Ticket.Priority;
            cbPriority.Enabled = false;
            tbCustomerName.Text = TicketControl.Ticket.CustomerName;
            tbCustomerName.ReadOnly = true;
            lbCreatedAt.Text = TicketControl.Ticket.CreatedAt.ToString("d MMM yyyy - h:mm tt");

            lbCreatedAtText.Visible = lbCreatedAt.Visible = btnCloseTicket.Visible = true;
            btnSubmit.Text = "Apply changes";
        }

        private async void LoadForNewTicket()
        {
            FormType = NEW_TICKET;

            cbStatus.DataSource = await TicketsRepo.ReadStoredProcedureAsync("GetTicketStatus"); cbStatus.Text = "";
            cbType.DataSource = await TicketsRepo.ReadStoredProcedureAsync("GetTicketType"); cbType.Text = "";
            cbPriority.DataSource = await TicketsRepo.ReadStoredProcedureAsync("GetTicketPriority"); cbPriority.Text = "";
            cbServiceType.DataSource = await TicketsRepo.ReadStoredProcedureAsync("GetTicketServiceType"); cbServiceType.Text = "";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {   
            switch (FormType)
            {
                case NEW_TICKET:
                    Ticket = new Ticket()
                    {
                        Subject = rtbSubject.Text,
                        Description = rtbDescription.Text,
                        Status = cbStatus.Text,
                        Type = cbType.Text,
                        ServiceType = cbServiceType.Text,
                        Priority = cbPriority.Text,
                        CustomerName = tbCustomerName.Text,
                        CreatedAt = DateTime.Now,
                        ClosedAt = null
                    };
                    DialogResult = DialogResult.OK;
                    InsertTicket(Ticket);
                    break;
                case EDIT_TICKET:
                    TicketControl.Ticket.Subject = rtbSubject.Text;
                    TicketControl.Ticket.Description = rtbDescription.Text;
                    UpdateTicket();
                    break;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCloseTicket_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to close this ticket?", "User Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TicketControl.Ticket.ClosedAt = DateTime.Now;
                    UpdateTicket();
                    TicketControl.RemoveTicketPanel();
                    break;
                case DialogResult.No:
                case DialogResult.Cancel:
                    break;
            }
        }

        private async void UpdateTicket()
        {
            TicketControl.FillTicket(TicketControl.Ticket);
            await TicketsRepo.UpdateAsync(TicketControl.Ticket);
            this.Close();
        }

        private async void InsertTicket(Ticket ticket)
        {
            await TicketsRepo.InsertByUserAsync(ticket, MainForm.MyAccount.Id);
            this.Close();
        }
    }
}
