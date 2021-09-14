using Minesweeper.Common.Data;
using Minesweeper.Logic.Actions;
using System;
using System.Collections.Generic;

namespace Minesweeper.Logic.Rules
{
    public class CellFlaggingRule
    {
        public IEnumerable<IAction> FlagCell(Game.Game game, Position pos)
        {
            var action = game.Board.Cells.TryGetValue(pos, out var cell)
                ? !cell.IsOpen
                    ? cell.IsFlagged ? (IAction)new DeFlagCellAction(pos) : new FlagCellAction(pos)
                    : new EmptyAction()
                : throw new ArgumentOutOfRangeException("Could not find cell at given position");
            return new[] { action };
        }
    }
}