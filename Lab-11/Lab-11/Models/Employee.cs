using System;
using System.ComponentModel.DataAnnotations;
using Lab_11.Models.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab_11.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Enter date of birth.")]
        [PastDate(ErrorMessage = "Birth date must be a valid past date")]
        [Remote("CheckEmployee", "Validation", AdditionalFields = "Firstname, Lastname")]
        [Display(Name = "Birth Date")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Enter date hired.")]
        [GreaterThan("1/1/1995", ErrorMessage = "Hire date has to be a valid date in the past")]
        [PastDate(ErrorMessage = "Birth date must be a valid past date")]
        [Display(Name = "Hire Date")]
        public DateTime? DateOfHire { get; set; }

        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Enter a first name.")]
        [Display(Name = "First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        public string FullName => $"{FirstName } {LastName }";

        [Required(ErrorMessage = "Enter a last name.")]
        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [GreaterThan(0, ErrorMessage = "Please select a manger")]
        [Remote("CheckManager", "Validation", AdditionalFields = "Firstname, Lastname, DateOfBirth")]
        [Display(Name = "Manager")]
        public int ManagerId { get; set; }
    }
}