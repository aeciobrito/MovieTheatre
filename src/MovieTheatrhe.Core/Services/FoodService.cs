using MovieTheatre.Core.Models;
using MovieTheatre.Core.Repositories.Interfaces;
using MovieTheatre.Core.Services.Interfaces;
using System.Linq.Expressions;

namespace MovieTheatre.Core.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepo;

        public FoodService(IFoodRepository foodRepo)
        {
            _foodRepo = foodRepo;
        }

        public Task<FoodItem> AddAsync(FoodItem entity)
        {
            //validation
            return _foodRepo.AddAsync(entity);
        }

        public async Task<FoodItem> DeleteAsync(int id)
        {
            //validation
            return await _foodRepo.DeleteAsync(id);
        }

        public async Task<IEnumerable<FoodItem>> Find(Expression<Func<FoodItem, bool>> predicate)
        {
            //validation
            return await _foodRepo.Find(predicate);
        }

        public async Task<List<FoodItem>> GetAllAsync()
        {
            //validation
            return await _foodRepo.GetAllAsync();
        }

        public async Task<List<FoodItem>> GetAllSold()
        {
            //validation
            return await _foodRepo.GetAllSoldAsync();
        }

        public async Task<FoodItem> GetAsync(int id)
        {
            //validation
            return await _foodRepo.GetAsync(id);
        }

        public async Task<FoodItem> UpdateAsync(FoodItem entity)
        {
            //validation
            return await _foodRepo.UpdateAsync(entity);
        }
    }
}
