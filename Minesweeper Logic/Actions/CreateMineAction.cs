using Minesweeper.Common.Data;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Visitor;
using System.Collections.Generic;

namespace Minesweeper.Logic.Actions
{
    public class CreateMineAction : IAction
    {
        private Position pos;

        public CreateMineAction(Position pos)
        {
            this.pos = pos;
        }

        public T Visit<T>(IActionVisitor<T> visitor)
        {
            return visitor.Accept(this);
        }

        public Game.Game Execute(Game.Game game)
        {
            game.Board.Cells.Remove(this.pos);
            game.Board.Cells.Add(this.pos, new CellWithMine());
            return game;
        }

        public IEnumerable<Position> ChangedPositions()
        {
            return new[] { this.pos };
        }
    }
}