using GameOfLife.Domain;
using Xunit;

namespace GameOfLife.Tests
{
    public class UnitTest1
    {
        // 50 mins!!!
        [Fact]
        public void CreateNextGeneration_OneDeadCell_CellStillDead()
        {
            //Arrange
            var grid = new Grid();

            //Act
            grid.AddCellIn(rowIndex: 0, columnIndex: 0);

            var nextGenGrid = grid.CreateNextGeneration();

            var cellState = nextGenGrid.GetStateOfCellIn(rowIndex: 0, columnIndex: 0);

            //Assert
            Assert.Equal(CellState.Dead, cellState);
        }
    }
}
