using System;
using System.Collections.Generic;
using System.Linq;
using Minesweeper.Common.Data;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Rules
{
    public class OpenCellRule : ICellVisitor<bool>
    {
        public IEnumerable<IAction> OpenCell (Game.Game game, Position pos)
        {
            if (game.Board.Cells.TryGetValue(pos, out var openedCell) && !openedCell.IsFlagged)
            {
                var result = new List<Position>();
                result.Add(pos);
                result.AddRange(this.CheckCells(pos, game.Board.Cells, result));

                return result.Select(p => new OpenCellAction(p));
            }

            return new[] {new EmptyAction()};
        }

        private List<Position> CheckCells(Position lastOpenedCell, Dictionary<Position, Cell> cells, List<Position> foundCells)
        {
            if (cells.TryGetValue(lastOpenedCell, out var openedCell))
            {
                if (openedCell.Accept<bool>(this))
                {
                    var p = cells.Keys.Where
                    (k => 
                        k.Distance(lastOpenedCell) == 1
                          && !foundCells.Contains(k));
                    foreach (var pos in p)
                    {
                        if (cells.TryGetValue(pos, out var newCell) && !newCell.IsFlagged)
                        {
                            foundCells.Add(pos);

                            this.CheckCells(pos, cells, foundCells);
                        }
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