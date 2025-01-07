using Scholarly.Models;
using Microsoft.EntityFrameworkCore;



namespace Scholarly.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<users> user { get; set; }
    }
}
