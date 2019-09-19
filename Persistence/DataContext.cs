using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testCrm.API.Model;

namespace testCrm.API.Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ContactData> ContactData { get; set; }
        public DbSet<TaskTicket> TaskTickets { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketType { get; set; }

    }
}
