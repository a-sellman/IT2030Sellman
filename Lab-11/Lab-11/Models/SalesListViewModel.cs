using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_11.Models
{
    public class SalesListViewModel
    {
        public List<Employee> Employee { get; set; }
        public int EmployeeId { get; set; }
        public List<Sales> Sales { get; set; }
    }
}