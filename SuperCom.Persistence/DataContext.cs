using Microsoft.EntityFrameworkCore;
using SuperCom.Domain;

namespace SuperCom.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}