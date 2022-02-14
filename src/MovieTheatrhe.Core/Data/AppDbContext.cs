using Microsoft.EntityFrameworkCore;
using MovieTheatrhe.Core.Models;

namespace MovieTheatrhe.Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }

        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
