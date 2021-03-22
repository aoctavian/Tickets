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

        private void LogInDialogShow()
        {
            using (var LIF = new LogInForm())
            {
                if (LIF.ShowDialog() == DialogResult.OK)
                {
                    Id = LIF.Id;
                    User = LIF.User;
                    ShowTickets(Id);
                }
            }
        }

        private void ShowTickets(int Id)
        {

        }
    }
}
