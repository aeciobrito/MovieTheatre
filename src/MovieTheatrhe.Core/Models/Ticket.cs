using MovieTheatrhe.Core.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatrhe.Core.Models
{
    public class Ticket : IEntity
    {
        public int Id { get; set; }

        [DisplayName("Movie Name")]
        public string MovieName { get; set; } = String.Empty;

        [DisplayName("Sale Price")]
        public decimal SalePrice { get; set; }

        [DisplayName("Studio Percentage")]
        public decimal StudioCutPercentage { get; set; }

        public int Quantity { get; set; }

        [DisplayName("Total Profit")]
        [DataType(DataType.Currency)]
        public decimal Profit 
        { 
            get => (Quantity * SalePrice) - (StudioCutPercentage * (Quantity * SalePrice)); 
        }

        [DisplayName("Profit Per Item")]
        [DataType(DataType.Currency)]
        public decimal ProfitPerItem
        {
            get => SalePrice - (StudioCutPercentage * SalePrice);
        }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    } 
}
