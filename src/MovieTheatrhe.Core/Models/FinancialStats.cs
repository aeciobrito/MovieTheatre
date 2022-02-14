using MovieTheatrhe.Core.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatrhe.Core.Models
{
    internal class FinancialStats : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }

        [DisplayName("Avg. Ticket Profit: ")]
        [DataType(DataType.Currency)]
        public decimal AverageTicketProfit { get; set; }

        [DisplayName("Avg. Food Item Profit: ")]
        [DataType(DataType.Currency)]
        public decimal AverageFoodItemProfit { get; set; }
    }
}
