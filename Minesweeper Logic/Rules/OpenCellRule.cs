using System;
using System.Collections.Generic;
using System.Linq;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Data;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Rules
{
    public class OpenCellRule : ICellVisitor<bool>
    {
        public IEnumerable<IAction> OpenCell (Game.Game game, Position pos)
        {
            var result = new List<Position>();

            result.Add(pos);
            
            result.AddRange(this.CheckCells(pos, game.Board.Cells, result));

            return result.Select(p => new OpenCellAction(p));
        }

        private List<Position> CheckCells(Position lastOpenedCell, Dictionary<Position, Cell> cells, List<Position> foundCells)
        {
            if (cells.TryGetValue(lastOpenedCell, out var openedCell))
            {
                if (openedCell.Accept(this))
                {
                    foreach (var pos in cells.Keys.Where
                    (k => Enumerable.Range(lastOpenedCell.X - 1, lastOpenedCell.X + 1).Contains(k.X)
                          && Enumerable.Range(lastOpenedCell.Y - 1, lastOpenedCell.Y + 1).Contains(k.Y)))
                    {
                        foundCells.Add(pos);
                        this.CheckCells(pos, cells, foundCells);
                    }

                    return foundCells;
                }
                else
                {
                    return foundCells;
                }
            }
            else
            {
                throw new ArgumentException("Could not find last opened cell");
            }
        } 

        public bool Visit(EmptyCell cell)
        {
            return true;
        }

        public bool Visit(CellWithMine cell)
        {
            return false;
        }

        public bool Visit(NumberedCell cell)
        {
            return false;
        }
    }
}