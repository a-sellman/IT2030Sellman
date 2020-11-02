using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06.Models
{
    public class FAQ
    {
        public string Answer { get; set; }
        public Category Category { get; set; }
        public string CategoryId { get; set; }
        public int Id { get; set; }
        public string Question { get; set; }
        public Topic Topic { get; set; }
        public string TopicId { get; set; }
    }
}