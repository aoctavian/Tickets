using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Model;

namespace Tickets
{
    public interface ITicketRepository : IDatabaseRepository<Ticket>
    {
        Task<List<Ticket>> GetAllTicketsForUserAsync(int userId);

        Task<List<string>> ReadStoredProcedureAsync(string procedureName);

        Task InsertByUserAsync(Ticket entity, int userId);
    }
}
