using MovieTheatre.Core.Models;

namespace MovieTheatre.Core.Repositories.Interfaces
{
    public interface IFoodRepository : IRepository<FoodItem>
    {
        Task<List<FoodItem>> GetAllSoldAsync();
    }
}
