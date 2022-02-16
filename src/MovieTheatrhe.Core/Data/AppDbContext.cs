using Microsoft.EntityFrameworkCore;
using MovieTheatre.Core.Models;

namespace MovieTheatre.Core.Data
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
