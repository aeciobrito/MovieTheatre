using MovieTheatrhe.Core.Models;
using MovieTheatrhe.Core.Repositories.Interfaces;
using MovieTheatrhe.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatrhe.Core.Services
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
