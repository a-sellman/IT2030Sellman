using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Lab_11.Models
{
    public class Sales
    {
        [Required(ErrorMessage = "Enter an amount")]
        public double? Amount { get; set; }

        [Display(Name = "Employee")]
        public Employee Employee { get; set; }

        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Enter a quarter")]
        [Range(1, 4, ErrorMessage = "Quarter must be between 1 and 4")]
        public int? Quarter { get; set; }

        public int SalesId { get; set; }

        [Required(ErrorMessage = "Enter a year")]
        public int? Year { get; set; }
    }
}