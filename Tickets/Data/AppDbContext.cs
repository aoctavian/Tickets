using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Model;

namespace Tickets.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext() : base("TicketsContext") { }

        public DbSet<Account> Account { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<UserTickets> UserTickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<UserTickets>().ToTable("UserTickets").HasKey(k => new { k.IdUser, k.IdTicket });
        }
    }
}
