using Minesweeper.Common.Data;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Visitor;
using System.Collections.Generic;

namespace Minesweeper.Logic.Actions
{
    public class IncreaseNumberedCellAction : IAction, ICellVisitor<bool>
    {
        private Position pos;

        public IncreaseNumberedCellAction(Position pos)
        {
            this.pos = pos;
        }

        public T Visit<T>(IActionVisitor<T> visitor)
        {
            return visitor.Accept(this);
        }

        public Game.Game Execute(Game.Game game)
        {
            game.Board.Cells.TryGetValue(this.pos, out var cell);
            if (cell.Accept(this))
            {
                var numCell = (NumberedCell)cell;
                numCell.Num++;
            }
            else
            {
                game.Board.Cells.Remove(this.pos);
                game.Board.Cells.Add(this.pos, new NumberedCell(1));
            }

            return game;
        }

        public IEnumerable<Position> ChangedPositions()
        {
            return new[] { this.pos };
        }

        public bool Visit(EmptyCell _)
        {
            return false;
        }

        public bool Visit(CellWithMine _)
        {
            return false;
        }

        public bool Visit(NumberedCell _)
        {
            return true;
        }
    }
}