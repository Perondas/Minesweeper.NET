using System;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Data;

namespace Minesweeper.Logic.Rules
{
    public class CellFlaggingRule
    {
        public IAction FlagCell(Game.Game game, Position pos)
        {
            return game.Board.Cells.TryGetValue(pos, out var cell)
                ? !cell.IsOpen
                    ? cell.IsFlagged ? (IAction) new DeFlagCellAction(pos) : new FlagCellAction(pos)
                    : new EmptyAction()
                : throw new ArgumentOutOfRangeException("Could not find cell at given position");
        }
    }
}