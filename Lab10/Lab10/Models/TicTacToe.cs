using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10.Models
{
    public class TicTacTBoard
    {
        public TicTacTBoard()
        {
            string[] rows = new string[] { "Top", "Middle", "Bottom" };
            string[] cols = new string[] { "Left", "Middle", "Right" };

            cells = new List<Cell>();

            foreach (string row in rows)
            {
                foreach (string col in cols)
                {
                    Cell cell = new Cell { Id = row + col };
                    cells.Add(cell);
                }
            }
        }

        public bool HasAllCellsSelected { get; set; }

        public bool HasWinner { get; set; }

        public string WinningMark { get; set; }

        private List<Cell> cells { get; set; }

        public void CheckForWinner()
        {
            HasWinner = false;
            WinningMark = null;
            HasAllCellsSelected = false;

            string winningMark = null;
            switch (true)
            {
                case true when IsWinner(0, 1, 2, out winningMark): //Top
                case true when IsWinner(3, 4, 5, out winningMark): //Middle
                case true when IsWinner(6, 7, 8, out winningMark): //Bottom

                case true when IsWinner(0, 3, 6, out winningMark): //Left Col
                case true when IsWinner(1, 4, 7, out winningMark): //Middle Col
                case true when IsWinner(2, 5, 8, out winningMark): //Right Col

                case true when IsWinner(0, 4, 8, out winningMark): //Left - right diag
                case true when IsWinner(2, 7, 6, out winningMark): //Right - left diag
                    HasWinner = true;
                    break;

                default:
                    HasWinner = false;
                    break;
            }
            WinningMark = winningMark;
            HasAllCellsSelected = true;

            foreach (Cell cell in cells)
            {
                if (cell.IsBlank)
                {
                    HasAllCellsSelected = false;
                    return;
                }
            }

            public List<Cell> GetCells() => cells;
        }

        private bool IsWinner(int mark1, int mark2, int mark3, out string WinningMark)
        {
            if (cells[mark1].Mark == cells[mark2].Mark && cells[mark2].Mark == cells[mark3].Mark && string.IsNullOrEmpty(cells[mark1].Mark))
            {
                WinningMark = cells[mark1].Mark;
                return true;
            }
            WinningMark = null;
            return false;
        }
    }
}