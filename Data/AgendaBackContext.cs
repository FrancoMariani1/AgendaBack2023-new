using AgendaBack2023.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaBack2023.Data
{
    public class AgendaBackContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Location> Locations { get; set; }
        public AgendaBackContext(DbContextOptions<AgendaBackContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = true;
        }
    }
}
