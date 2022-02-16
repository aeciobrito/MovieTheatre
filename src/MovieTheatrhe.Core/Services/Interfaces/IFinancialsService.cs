using MovieTheatre.Core.Models;

namespace MovieTheatre.Core.Services.Interfaces
{
    public interface IFinancialsService
    {
        public decimal GetTotalSold();
        public FinancialStats GetStats();
    }
}
