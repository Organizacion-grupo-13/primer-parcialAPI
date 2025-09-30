using Microsoft.EntityFrameworkCore;

namespace primer_parcialAPI.Data
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        // Aquí cada integrante añadirá su DbSet más adelante:
        // public DbSet<Product> Products { get; set; }
        // public DbSet<Event> Events { get; set; }
        // public DbSet<SupportTicket> SupportTickets { get; set; }
    }
}