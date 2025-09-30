using Microsoft.EntityFrameworkCore;
using primer_parcialAPI.Models;

namespace primer_parcialAPI.Data
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<SupportTicket> SupportTickets { get; set; }  // ← Javier
    }
}