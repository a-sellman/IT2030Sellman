using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Lab14.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Please enter an email.")]
        public int CategoryID { get; set; }

        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string Email { get; set; }

        [Key]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public int PhoneNumber { get; set; }

        //        public Category Category { get; set; }
    }
}