using System.ComponentModel.DataAnnotations;

namespace _2_1.Models
{
    public class PriceQuotation
    {
        public decimal DiscountAmount { get; set; }

        [Display(Name = "Discount Percent")]
        [Required]
        [Range(0, 100)]
        public int DiscountPercent { get; set; }

        [Display(Name = "Subtotal")]
        [Required]
        [DataType(DataType.Currency)]
        public decimal Subtotal { get; set; }

        public decimal Total { get; set; }
    }
}