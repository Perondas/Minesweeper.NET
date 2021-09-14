using Minesweeper.Common.Data;
using Minesweeper.Logic.Visitor;
using System.Collections.Generic;

namespace Minesweeper.Logic.Actions
{
    public class EmptyAction : IAction
    {
        public T Visit<T>(IActionVisitor<T> visitor)
        {
            return visitor.Accept(this);
        }

        public Game.Game Execute(Game.Game game)
        {
            return game;
        }

        public IEnumerable<Position> ChangedPositions()
        {
            return new List<Position>();
        }
    }
}