using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class TicketForm : Form
    {
        private const int NEW_TICKET = 0, EDIT_TICKET = 1;
        private int FormType { get; set; }

        TicketControl TicketControl { get; set; }
        public Ticket Ticket { get; set; }

        public TicketForm(TicketControl ticketControl) //edit ticket constructor
        {
            InitializeComponent();

            TicketControl = ticketControl;
            LoadForEditing(ticketControl);
        }

        public TicketForm() //new ticket constructor
        {
            InitializeComponent();

            LoadForNewTicket();
        }

        private void LoadForEditing(TicketControl ticketControl)
        {
            FormType = EDIT_TICKET;

            rtbSubject.Text = TicketControl.Ticket.Subject;
            rtbDescription.Text = TicketControl.Ticket.Description;
            lbStatus.Text = TicketControl.Ticket.Status;
            lbStatus.Enabled = false;
            lbType.Text = TicketControl.Ticket.Type;
            lbType.Enabled = false;
            lbServiceType.Text = TicketControl.Ticket.ServiceType;
            lbServiceType.Enabled = false;
            lbPriority.Text = TicketControl.Ticket.Priority;
            lbPriority.Enabled = false;
            lbCustomerName.Text = TicketControl.Ticket.CustomerName;
            lbCustomerName.ReadOnly = true;
            lbCreatedAt.Text = TicketControl.Ticket.CreatedAt.ToString("dd.MM.yyyy - HH:mm");

            lbCreatedAtText.Visible = lbCreatedAt.Visible = btnCloseTicket.Visible = true;
            btnSubmit.Text = "Apply changes";
        }

        private void LoadForNewTicket()
        {
            FormType = NEW_TICKET;

            //TODO Load stored procedures
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
                        Status = lbStatus.Text,
                        Type = lbType.Text,
                        ServiceType = lbServiceType.Text,
                        Priority = lbPriority.Text,
                        CustomerName = lbCustomerName.Text,
                        CreatedAt = DateTime.Now,
                        ClosedAt = null
                    };
                    DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case EDIT_TICKET:
                    TicketControl.Ticket.Subject = rtbSubject.Text;
                    TicketControl.Ticket.Description = rtbDescription.Text;
                    TicketControl.FillTicket(TicketControl.Ticket);
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
                    TicketControl.FillTicket(TicketControl.Ticket);
                    this.Close();
                    break;
                case DialogResult.No:
                case DialogResult.Cancel:
                    break;
            }
        }
    }
}
