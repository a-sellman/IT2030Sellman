using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_12.Models
{
    public class ManageViewModel
    {
        public Accomodation Accomodation { get; set; }
        public int AccomodationId { get; set; }
        public Activity Activity { get; set; }
        public Destination Destination { get; set; }
    }
}