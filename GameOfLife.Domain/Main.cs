using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Domain
{
    public class Grid
    {
        private readonly List<Cell> Cells = new List<Cell>();

        public void AddCellIn(int rowIndex, int columnIndex)
        {
            var cell = new Cell(
                positionX: columnIndex, 
                positionY: rowIndex, 
                state: CellState.Dead
            );

            Cells.Add(cell);
        }

        public Grid CreateNextGeneration()
        {
            var nextGenGrid = new Grid();

            foreach (var cell in Cells)
            {
                nextGenGrid.AddCellIn(cell.PositionX, cell.PositionY);
            }

            return nextGenGrid;
        }

        public CellState GetStateOfCellIn(int rowIndex, int columnIndex)
        {
            var cell = Cells.SingleOrDefault(cell =>
                cell.PositionX == columnIndex &&
                cell.PositionY == rowIndex
            );

            return cell.State;
        }
    }

    public class Cell
    {
        public Cell(int positionX, int positionY, CellState state)
        {
            PositionX = positionX;
            PositionY = positionY;
            State = state;
        }

        public int PositionX { get; private set; }

        public int PositionY { get; private set; }

        public CellState State { get; private set; }
    }

    public enum CellState
    {
        Dead,
        Alive
    }
}
