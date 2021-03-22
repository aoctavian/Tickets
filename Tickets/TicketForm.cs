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
        Ticket Ticket { get; set; }

        public TicketForm(Ticket ticket)
        {
            Ticket = ticket;
            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {

        }
    }
}
