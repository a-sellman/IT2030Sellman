﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _4_1.Models
{

    public class Contact
    {
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public int? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Please enter an email.")]
        public string CategoryID { get; set; }
        public Category Category { get; set; }

    }
}