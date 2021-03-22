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
    public partial class TicketControl : UserControl
    {
        public Ticket Ticket { get; set; }
        public TicketControl(Ticket ticket)
        {
            Ticket = ticket;
            InitializeComponent();

            FillTicket(ticket);
        }

        public void FillTicket(Ticket ticket)
        {
            lbSubject.Text = ticket.Subject;
            lbTicketStatus.Text = ticket.Status;
            lbTicketType.Text = ticket.Type;
            lbServiceType.Text = ticket.ServiceType;
            lbCustomerName.Text = ticket.CustomerName;
            lbCreatedAt.Text = ticket.CreatedAt.ToString("d MMM yyyy - h:mm tt");
            if (!IsNotClosed(ticket))
            {
                this.BackColor = Color.Gainsboro;
                lbClosedAtText.Visible = true;
                lbClosedAt.Text = ((DateTime)ticket.ClosedAt).ToString("d MMM yyyy - h:mm tt");
                lbClosedAt.Visible = true;
                overlayPanel.Cursor = Cursor.Current;
            }
        }

        public void RemoveTicketPanel()
        {
            this.Parent.Controls.Remove(this);
        }

        private void Ticket_Click(object sender, EventArgs e)
        {
            if (IsNotClosed(Ticket))
            {
                var tf = new TicketForm(this);
                tf.Show();
            }
        }

        private void Ticket_MouseEnter(object sender, EventArgs e)
        {
            if (IsNotClosed(Ticket))
            {
                this.BorderStyle = BorderStyle.FixedSingle;
                this.BackColor = Color.WhiteSmoke;
            }
        }

        private void Ticket_MouseLeave(object sender, EventArgs e)
        {
            if (IsNotClosed(Ticket))
            {
                this.BorderStyle = BorderStyle.Fixed3D;
                this.BackColor = SystemColors.Window;
            }
        }

        private bool IsNotClosed(Ticket ticket)
        {
            return ticket.ClosedAt == null;
        }
    }
}
