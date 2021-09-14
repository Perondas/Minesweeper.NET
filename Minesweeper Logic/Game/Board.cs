using Minesweeper.Common.Data;
using System.Collections.Generic;

namespace Minesweeper.Logic.Game
{
    public class Board
    {
        public Board(int x, int y)
        {
            this.XSize = x;
            this.YSize = y;
            this.Cells = new Dictionary<Position, Cell>();
        }

        public int XSize { get; private set; }

        public int YSize { get; private set; }

        public Dictionary<Position, Cell> Cells { get; private set; }
    }
}