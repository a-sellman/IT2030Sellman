using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public string ThingToDo1 { get; set; }

        public string ThingToDo2 { get; set; }

        public string ThingToDo3 { get; set; }

        [Required(ErrorMessage = "Please Enter A Destination.")]
        [Key]
        public string TripID { get; set; }
    }
}