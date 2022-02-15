using MovieTheatrhe.Core.Models;
using MovieTheatrhe.Core.Repositories.Interfaces;
using MovieTheatrhe.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
        }

        public Task<FoodItem> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FoodItem>> Find()
        {
            throw new NotImplementedException();
        }

        public Task<List<FoodItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<FoodItem>> GetAllSold()
        {
            throw new NotImplementedException();
        }

        public Task<FoodItem> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FoodItem> UpdateAsync(FoodItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
