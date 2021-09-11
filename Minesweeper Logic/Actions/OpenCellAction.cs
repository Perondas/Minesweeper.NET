using System;
using System.Collections.Generic;
using Minesweeper.Common.Data;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Actions
{
    public class OpenCellAction : IAction
    {
        private Position pos;

        public OpenCellAction(Position pos)
        {
            this.pos = pos;
        }

        public Game.Game Execute(Game.Game game)
        {
            if (!game.Board.Cells.TryGetValue(this.pos, out var cell))
                throw new ArgumentOutOfRangeException("Could not find a cell at the specified position");
            cell.IsOpen = true;
            return game;
        }

        public IEnumerable<Position> ChangedPositions()
        {
            return new[] {this.pos};
        }

        public T Visit<T>(IActionVisitor<T> visitor)
        {
            return visitor.Accept(this);
        }
    }
}