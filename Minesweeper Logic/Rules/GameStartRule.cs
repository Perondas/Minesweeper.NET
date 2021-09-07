using System;
using System.Linq;
using Minesweeper.Common.Data;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Rules
{
    public class GameStartRule : ICellVisitor<int>
    {
        public Game.Game StartGame(Game.Game game, Position firstPosition, int mineCount)
        {
            var rand = new Random();
            for (uint x = 0; x < mineCount; x++)
            {
                var pos = new Position(rand.Next(0, game.Board.XSize), rand.Next(0, game.Board.YSize));
                if (game.Board.Cells.ContainsKey(pos))
                {
                    x--;
                    continue;
                }

                game.Board.Cells.Add(pos, new CellWithMine());
            }

            var keys = game.Board.Cells.Keys.ToList();
            foreach (var minePos in keys)
            {
                for (var x1 = -1; x1 < 2; x1++)
                {
                    for (var y1 = -1; y1 < 2; y1++)
                    {
                        var newPos = new Position(minePos.X + x1, minePos.Y + y1);
                        if (newPos.IsPositive())
                        {
                            if (game.Board.Cells.TryGetValue(newPos, out var cell))
                            {
                                if (cell.Accept(this) == 0)
                                {
                                    game.Board.Cells.Remove(newPos);
                                    game.Board.Cells.Add(newPos, new NumberedCell(1));
                                }
                                else if (cell.Accept(this) < 9)
                                {
                                    var numCell = (NumberedCell) cell;
                                    numCell.Num++;
                                }
                            }
                            else if (newPos.X < game.Board.XSize && newPos.Y < game.Board.YSize)
                            {
                                game.Board.Cells.Add(newPos, new NumberedCell(1));
                            }
                        }
                    }
                }
            }

            for (int x = 0; x < game.Board.XSize; x++)
            {
                for (int y = 0; y < game.Board.YSize; y++)
                {
                    var newPos = new Position(x, y);
                    if (game.Board.Cells.ContainsKey(newPos))
                    {
                        continue;
                    }
                    else
                    {
                        game.Board.Cells.Add(newPos, new EmptyCell());
                    }
                }
            }

            return game;
        }

        public int Visit(EmptyCell cell)
        {
            return 0;
        }

        public int Visit(CellWithMine cell)
        {
            return 9;
        }

        public int Visit(NumberedCell cell)
        {
            return cell.Num;
        }
    }
}