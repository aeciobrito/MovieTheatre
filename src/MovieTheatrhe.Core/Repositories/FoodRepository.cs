using Microsoft.EntityFrameworkCore;
using MovieTheatrhe.Core.Data;
using MovieTheatrhe.Core.Models;
using MovieTheatrhe.Core.Repositories.Interfaces;

namespace MovieTheatrhe.Core.Repositories
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
