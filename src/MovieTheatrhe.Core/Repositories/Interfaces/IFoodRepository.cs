using MovieTheatrhe.Core.Models;

namespace MovieTheatrhe.Core.Repositories.Interfaces
{
    public interface IFoodRepository : IRepository<FoodItem>
    {
        Task<List<FoodItem>> GetAllSoldAsync();
    }
}
