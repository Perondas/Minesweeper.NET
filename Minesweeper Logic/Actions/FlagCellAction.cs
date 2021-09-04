using System;
using Minesweeper.Common.Data;

namespace Minesweeper.Logic.Actions
{
    public class FlagCellAction : IAction
    {
        private Position pos;

        public FlagCellAction(Position pos)
        {
            this.pos = pos;
        }

        public Game.Game Execute(Game.Game game)
        {
            if (!game.Board.Cells.TryGetValue(this.pos, out var cell))
                throw new ArgumentOutOfRangeException("Could not find a cell at the specified position");
            cell.IsFlagged = true;
            return game;
        }

        public T Visit<T>(IActionVisitor<T> visitor)
        {
            return visitor.Accept(this);
        }
    }
}