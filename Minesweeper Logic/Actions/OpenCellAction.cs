using System;
using Minesweeper.Logic.Data;
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
            cell.Open();
            return game;
        }
    }
}