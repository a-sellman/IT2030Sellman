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
        public int? Accomodation { get; set; }
        public Accomodation Accomodation { get; set; }
        public Destination Destination { get; set; }

        [Range(1, 999999999, ErrorMessage = "Please enter a destination")]
        public int DestinationId { get; set; }

        [Required(ErrorMessage = "Please enter an end date")]
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "Please enter a start date")]
        public DateTime? StartDate { get; set; }

        public ICollection<TripActivity> TripActivities { get; set; }
        public int TripId { get; set; }
    }
}