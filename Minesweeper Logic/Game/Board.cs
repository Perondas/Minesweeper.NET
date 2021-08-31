using System.Collections.Generic;
using Minesweeper.Logic.Data;

namespace Minesweeper.Logic.Game
{
    public class Board
    {
        public Board()
        {
            this.Cells = new Dictionary<Position, Cell>();
        }
        public Dictionary<Position, Cell> Cells { get; private set; }
    }
}