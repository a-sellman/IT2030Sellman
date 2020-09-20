using System.ComponentModel.DataAnnotations;

namespace _4_1.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Please enter an email.")]
        public int CategoryID { get; set; }

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