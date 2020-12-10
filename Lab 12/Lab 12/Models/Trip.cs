using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab_12.Models
{
    public class Trip
    {
        public string Accomodation { get; set; }

        public string AccomodationEmail { get; set; }

        public string AccomodationPhone { get; set; }

        [Required(ErrorMessage = "Please enter a destination")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Please enter an end date")]
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "Please enter a start date")]
        public DateTime? StartDate { get; set; }

        public string ThingToDo1 { get; set; }

        public string ThingToDo2 { get; set; }

        public string ThingToDo3 { get; set; }

        public int TripId { get; set; }
    }
}