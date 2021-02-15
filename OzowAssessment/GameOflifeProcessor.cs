using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace OzowAssessment
{
    public class GameOflifeProcessor
    {
        private CellState _cellState;

        public GameOflifeProcessor(CellState cellState)
        {
            _cellState = cellState;
        }

        public void ProcessCellState(int state)
        {
            if (_cellState == CellState.Alive && (state == 0 || state == 1))
            {
                _cellState = CellState.Dead;
            }
            if (_cellState == CellState.Alive && (state == 2 || state == 3))
            {
                _cellState = CellState.Alive;
            }
            if (_cellState == CellState.Alive && (state > 3))
            {
                _cellState = CellState.Dead;
            }
            if (_cellState == CellState.Dead && (state == 3))
            {
                _cellState = CellState.Alive;
            }
        }
        public CellState CurrentCellState
        {
            get { return _cellState; }
        }
    }
}
