using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_12.Models
{
    public class Accomodation
    {
        public int AccomodationId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ICollection<Trip> Trips { get; set }
    }
}