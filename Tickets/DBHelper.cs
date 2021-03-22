using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public static class DBHelper
    {
        static SqlConnection connection = new SqlConnection("Data Source=OCTAVIAN;Initial Catalog=Tickets;Integrated Security=True;");

        public static async Task UpdateTicket(Ticket ticket)
        {
            try
            {
                await connection.OpenAsync();
            }
            catch
            {
                MessageBox.Show("Cannot connect to database", "Database down", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlCommand command = connection.CreateCommand();
            object closedAt;
            if (ticket.ClosedAt == null)
                closedAt = DBNull.Value;
            else
                closedAt = ticket.ClosedAt;
            command.CommandText = $"update ticket set [Subject] = '{ticket.Subject}', [Description] = '{ticket.Description}', [ClosedAt] = @closedDate where [Id] = {ticket.Id}";
            command.Parameters.AddWithValue("@closedDate", closedAt);
            await command.ExecuteNonQueryAsync();
            connection.Close();
        }

        public static async Task InsertTicket(Ticket ticket)
        {
            try
            {
                await connection.OpenAsync();
            }
            catch
            {
                MessageBox.Show("Cannot connect to database", "Database down", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlCommand command = connection.CreateCommand();
            object closedAt;
            if (ticket.ClosedAt == null)
                closedAt = DBNull.Value;
            else
                closedAt = ticket.ClosedAt;
            command.CommandText = $"insert into ticket values ('{ticket.Subject}', '{ticket.Description}', '{ticket.Status}', '{ticket.Type}', '{ticket.ServiceType}', '{ticket.Priority}', '{ticket.CustomerName}', @createdDate, null); SELECT SCOPE_IDENTITY();";
            command.Parameters.AddWithValue("@closedDate", closedAt);
            command.Parameters.AddWithValue("@createdDate", ticket.CreatedAt);
            int Id = Convert.ToInt32(await command.ExecuteScalarAsync());

            command.CommandText = $"insert into UserTickets values ({MainForm.Id}, {Id})";
            await command.ExecuteNonQueryAsync();

            connection.Close();
        }
    }
}
