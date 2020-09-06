using System.ComponentModel.DataAnnotations;

namespace _2_2.Models
{
    public class TipCalculation
    {
        [Display(Name = "cost of meal")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "The cost of a meal must be greater than 0.00.")]
        public decimal? CostOfMeal { get; set; }

        public decimal Tip15Percent { get; set; }

        public decimal Tip20Percent { get; set; }

        public decimal Tip25Percent { get; set; }
    }
}