using System;
using System.ComponentModel.DataAnnotations;

namespace Lab04.Models
{
    public class Contact
    {
        public Category Category { get; set; }

        [Range(1, 100000000, ErrorMessage = "Select a valid number")]
        public int CategoryID { get; set; }

        public int ContactId { get; set; }
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Enter an email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a first name.")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Enter a last name.")]
        public string Lastname { get; set; }

        public string Organization { get; set; }

        [Required(ErrorMessage = "Enter a phone number.")]
        public string Phone { get; set; }

        public string Slug =>
            this.Firstname?.Replace('-', '-').ToLower()
            + '-' + this.Lastname?.Replace(' ', '-').ToLower();
    }
}