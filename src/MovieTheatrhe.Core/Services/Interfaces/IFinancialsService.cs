using MovieTheatrhe.Core.Models;

namespace MovieTheatrhe.Core.Services.Interfaces
{
    public interface IFinancialsService
    {
        public decimal GetTotalSold();
        public FinancialStats GetStats();
    }
}
