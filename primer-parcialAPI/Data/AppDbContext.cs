using Microsoft.EntityFrameworkCore;
using primer_parcialAPI.Models;

namespace primer_parcialAPI.Data
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}


        public DbSet<Product> Products { get; set; }  // ← Brayan
        public DbSet<Event> Events { get; set; }  // ← José
        public DbSet<SupportTicket> SupportTickets { get; set; }  // ← Javier
    }
}//