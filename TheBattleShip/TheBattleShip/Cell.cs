using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShip
{
    internal class Cell
    {
        public enum CellState
        {
            Empty,
            Missed,
            Undamaged,
            Dead
        }

        public enum CellPosition
        {
            Correct,
            Invalid,
            OutOfRange
        }

        public CellState cellState;
        public CellPosition cellPosition;

        public Cell()
        {
            cellState = CellState.Empty;
        }

        public Cell(CellState cellState)
        {
            this.cellState = cellState;
        }
    }
}
