using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace OzowAssessment.Tests
{
    public class OzowAssessmentGameOfLifeTest
    {
        [Fact]
        public void AnyLiveCellWithOnlyOneNeighbourShouldDieTest()
        {
            var expected = CellState.Dead;
            var cell = new GameOflifeProcessor(CellState.Alive);
            cell.ProcessCellState(1);
                        
            Assert.Equal(expected, cell.CurrentCellState);
        }
        [Fact]
        public void AnyLiveCellWithZeroNeighboursShouldDieTest()
        {
            var expected = CellState.Dead;
            var cell = new GameOflifeProcessor(CellState.Alive);
            cell.ProcessCellState(0);

            Assert.Equal(expected, cell.CurrentCellState);
        }

        [Fact]
        public void AnyLiveCellWithTwoNeighboursShouldLiveTest()
        {
            var expected = CellState.Alive;
            var cell = new GameOflifeProcessor(CellState.Alive);
            cell.ProcessCellState(2);

            Assert.Equal(expected, cell.CurrentCellState);
        }

        [Fact]
        public void AnyLiveCellWithThreeNeighboursShouldLiveTest()
        {
            var expected = CellState.Alive;
            var cell = new GameOflifeProcessor(CellState.Alive);
            cell.ProcessCellState(3);

            Assert.Equal(expected, cell.CurrentCellState);
        }

        [Fact]
        public void AnyLiveCellWithMoreThanThreeNeighboursShouldDieTest()
        {
            var expected = CellState.Dead;
            var cell = new GameOflifeProcessor(CellState.Alive);

            //A random number above 3 => 4
            cell.ProcessCellState(4);
            Assert.Equal(expected, cell.CurrentCellState);

            //A random number above 3 => 13
            cell.ProcessCellState(13);

            Assert.Equal(expected, cell.CurrentCellState);
        }

        [Fact]
        public void AnyDeadCellWithExactlyThreeNeighboursShouldLiveTest()
        {
            var expected = CellState.Alive;
            var cell = new GameOflifeProcessor(CellState.Dead);
            cell.ProcessCellState(3);
            
            Assert.Equal(expected, cell.CurrentCellState);
        }
    }
}
