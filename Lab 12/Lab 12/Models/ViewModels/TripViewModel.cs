using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_12.Models
{
    public class TripViewModel : DropDownViewModel
    {
        public string DestinationName { get; set; }
        public int PageNumber { get; set; }
        public int[] SelectedActivities { get; set; }
        public Trip Trip { get; set; }
    }
}