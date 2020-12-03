using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_11.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Enter date of birth.")]
        [Display(Name = "Birth Date")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Enter date hired.")]
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

        public int ManagerId { get; set; }
    }
}