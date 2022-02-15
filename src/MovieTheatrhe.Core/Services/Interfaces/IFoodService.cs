using MovieTheatrhe.Core.Models;

namespace MovieTheatrhe.Core.Services.Interfaces
{
    public interface IFoodService
    {
        Task<List<FoodItem>> GetAllAsync();

        Task<FoodItem> GetAsync(int id);

        Task<FoodItem> AddAsync(FoodItem entity);

        Task<FoodItem> UpdateAsync(FoodItem entity);

       Task<FoodItem> DeleteAsync(int id);

        Task<IEnumerable<FoodItem>> Find();

        Task<List<FoodItem>> GetAllSold();
    }
}
