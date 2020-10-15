using System.ComponentModel.DataAnnotations;

namespace _8_1.Models
{
    public class Destination
    {
        public string AccomodationEmail { get; set; }

        public string AccomodationName { get; set; }

        public string AccomodationPhone { get; set; }

        [Required(ErrorMessage = "Please Enter An End Date")]
        public int EndDate { get; set; }

        [Required(ErrorMessage = "Please Enter A Start Date")]
        public int StartDate { get; set; }

        [Required(ErrorMessage = "Please Enter A Destination.")]
        [Key]
        public string TripID { get; set; }
    }
}