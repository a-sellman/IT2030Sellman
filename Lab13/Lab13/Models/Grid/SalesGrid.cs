using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13.Models
{
    public class SalesGrid : GridDTO
    {
        public const string DefaultFilter = "All";
        public string Employee { get; set; } = DefaultFilter;
        public string Quarter { get; set; } = DefaultFilter;
        public string Year { get; set; } = DefaultFilter;
    }
}