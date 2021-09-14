﻿using Minesweeper.Common.Data;
using Minesweeper.Logic.Visitor;
using System;
using System.Collections.Generic;

namespace Minesweeper.Logic.Actions
{
    public class DeFlagCellAction : IAction
    {
        private Position pos;

        public DeFlagCellAction(Position pos)
        {
            this.pos = pos;
        }

        public Game.Game Execute(Game.Game game)
        {
            if (!game.Board.Cells.TryGetValue(this.pos, out var cell))
                throw new ArgumentOutOfRangeException("Could not find a cell at the specified position");
            cell.IsFlagged = false;
            return game;
        }

        public IEnumerable<Position> ChangedPositions()
        {
            return new[] { this.pos };
        }

        public T Visit<T>(IActionVisitor<T> visitor)
        {
            return visitor.Accept(this);
        }
    }
}