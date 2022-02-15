using MovieTheatrhe.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatrhe.Core.Repositories.Interfaces
{
    public interface IFoodRepository : IRepository<FoodItem>
    {
        Task<List<FoodItem>> GetAllSold();
    }
}
