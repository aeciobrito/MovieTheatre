using MovieTheatrhe.Core.Models.Interfaces;
using System.ComponentModel;

namespace MovieTheatrhe.Core.Models
{
    public class FoodItem : IEntity
    {
        public int Id { get; set; }
        [DisplayName("Item Name")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Sale Price")]
        public decimal SalePrice { get; set; }
        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Profit { get => (SalePrice * Quantity) - (UnitPrice * Quantity); }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
