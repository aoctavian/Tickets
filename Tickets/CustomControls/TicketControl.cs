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
        private Ticket Ticket { get; set; }
        public TicketControl(Ticket ticket)
        {
            Ticket = ticket;
            InitializeComponent();

            lbTicketStatus.Text = ticket.Status;
            lbTicketType.Text = ticket.Type;
            lbServiceType.Text = ticket.ServiceType;
            lbCustomer.Text = ticket.CustomerName;
            lbCreatedAt.Text = ticket.CreatedAt.ToString("HH:mm - dd.MM.yyyy");
        }

        private void Ticket_Click(object sender, EventArgs e)
        {
            var tf = new TicketForm(Ticket);
            tf.Show();
        }

        private void Ticket_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.WhiteSmoke;
        }

        private void Ticket_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BackColor = SystemColors.Window;
        }
    }
}
