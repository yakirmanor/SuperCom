using Microsoft.EntityFrameworkCore;
using SuperCom.Services.Models;
using System.Collections.Generic;

namespace SuperCom.Services.Repository
{
    public class SuperComTaskDbContext : DbContext
    {
        public SuperComTaskDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SuperComTask> SuperComTasks { get; set; }
    }
}
