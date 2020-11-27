using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10.Models
{
    public class TicTacViewModel
    {
        public List<Cell> Cells { get; set; }
        public bool IsGameOver { get; set; }
        public Cell Selected { get; set; }
    }
}