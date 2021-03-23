using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Data;
using Tickets.Model;

namespace Tickets
{
    public class TicketRepository : EntityFrameworkRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(AppDbContext context) : base(context) { }

        public async Task<List<Ticket>> GetAllTicketsForUserAsync(int userId)
        {
            var ticketsIDs = AppContext.UserTickets.Where(i => i.IdUser == userId).Select(i => i.IdTicket).ToList();
            return await _dbSet.Where(i => ticketsIDs.Contains(i.Id)).OrderByDescending(i => i.CreatedAt).ToListAsync();
        }

        public async Task<List<string>> ReadStoredProcedureAsync(string procedureName)
        {
            return await AppContext.Database.SqlQuery<string>(procedureName).ToListAsync();
        }

        public async Task InsertByUserAsync(Ticket entity, int userId)
        {
            _dbSet.Add(entity);
            await AppContext.SaveChangesAsync();
            AppContext.UserTickets.Add(new UserTickets() { IdUser = userId, IdTicket = entity.Id });
            await AppContext.SaveChangesAsync();
        }
    }
}
