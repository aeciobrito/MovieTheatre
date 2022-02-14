using MovieTheatrhe.Core.Data;
using MovieTheatrhe.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatrhe.Core.Repositories
{
    internal class FoodRepository : GenericRepository<FoodItem, AppDbContext>
    {
        public FoodRepository(AppDbContext context) : base(context)
        {
        }
    }
}
