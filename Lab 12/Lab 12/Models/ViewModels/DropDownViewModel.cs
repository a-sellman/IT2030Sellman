using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_12.Models
{
    public class DropDownViewModel
    {
        public IEnumerable<Accomodation> Accomodations { get; set; }
        public IEnumerable<Activity> Activities { get; set; }
        public IEnumerable<Destination> Destinations { get; set; }
    }
}