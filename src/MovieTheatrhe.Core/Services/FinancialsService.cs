using MovieTheatrhe.Core.Models;
using MovieTheatrhe.Core.Repositories.Interfaces;
using MovieTheatrhe.Core.Services.Interfaces;
using System.Linq;

namespace MovieTheatrhe.Core.Services
{
    public class FinancialsService : IFinancialsService
    {
        private readonly ITicketRepository _ticketRepo;
        private readonly IFoodRepository _foodRepo;

        public FinancialsService(ITicketRepository ticketRepo,
                                 IFoodRepository foodRepo)
        {
            _ticketRepo = ticketRepo;
            _foodRepo = foodRepo;
        }

        public decimal GetTotalSold()
        {            
            var foodSold = _foodRepo.GetAllSold().Result.Sum(x => x.Profit);
            var ticketsSold = _ticketRepo.GetAllSold().Result.Sum(x => x.Profit);

            return foodSold + ticketsSold;
        }

        public FinancialStats GetStats()
        {
            FinancialStats stats = new FinancialStats();
            var foodSold = _foodRepo.GetAllSold().Result;
            var ticketsSold = _ticketRepo.GetAllSold().Result;

            //Calculate Average Stats
            stats.AverageTicketProfit = ticketsSold.Sum(x => x.Profit) / ticketsSold.Sum(x => x.Quantity);
            stats.AverageFoodItemProfit = foodSold.Sum(x => x.Profit) / foodSold.Sum(x => x.Quantity);

            return stats;
        }
    }
}
