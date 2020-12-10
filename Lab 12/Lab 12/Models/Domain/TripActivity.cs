using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_12.Models
{
    public class TripActivity
    {
        public Activity Activity { get; set }
        public int ActivityId { get; set; }
        public Trip Trip { get; set; }
        public int TripId { get; set; }
    }
}