using MovieTheatre.Core.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatre.Core.Models
{
    public class FinancialStats
    {
        public int Id { get; set; }

        [DisplayName("Avg. Ticket Profit: ")]
        [DataType(DataType.Currency)]
        public decimal AverageTicketProfit { get; set; }

        [DisplayName("Avg. Food Item Profit: ")]
        [DataType(DataType.Currency)]
        public decimal AverageFoodItemProfit { get; set; }
    }
}
