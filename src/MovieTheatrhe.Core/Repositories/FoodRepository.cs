using Microsoft.EntityFrameworkCore;
using MovieTheatre.Core.Data;
using MovieTheatre.Core.Models;
using MovieTheatre.Core.Repositories.Interfaces;

namespace MovieTheatre.Core.Repositories
{
    public class FoodRepository : Repository<FoodItem, AppDbContext>, IFoodRepository
    {
        public FoodRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<FoodItem>> GetAllSoldAsync()
            => await _context.FoodItems.ToListAsync();
    }
}
