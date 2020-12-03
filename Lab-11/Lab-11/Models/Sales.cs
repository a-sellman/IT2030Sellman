using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Lab_11.Models.Validation;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace Lab_11.Models
{
    public class Sales
    {
        [Required(ErrorMessage = "Enter an amount")]
        [GreaterThan(0, ErrorMessage = "Amount must be greater than 0.")]
        public double? Amount { get; set; }

        [Display(Name = "Employee")]
        [GreaterThan(0, ErrorMessage = "Select an employee")]
        public Employee Employee { get; set; }

        [Remote("CheckSales", "Validation", AdditionalFields = "Quarter, Year")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Enter a quarter")]
        [Range(1, 4, ErrorMessage = "Quarter must be between 1 and 4")]
        public int? Quarter { get; set; }

        public int SalesId { get; set; }

        [Required(ErrorMessage = "Enter a year")]
        [GreaterThan(2000, ErrorMessage = "Date must be after 2000")]
        public int? Year { get; set; }
    }
}