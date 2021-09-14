using Minesweeper.Common.Data;
using Minesweeper.Logic.Actions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Minesweeper.Logic.Rules
{
    public class GameStartRule
    {
        public IEnumerable<IAction> StartGame(Game.Game game, Position firstPosition, int mineCount)
        {
            var mines = new List<IAction>();
            var rand = new Random();

            for (uint x = 0; x < mineCount; x++)
            {
                var pos = new Position(rand.Next(0, game.Board.XSize), rand.Next(0, game.Board.YSize));
                if (mines.Any(r => r.ChangedPositions().Contains(pos))
                    || pos.Distance(firstPosition) <= 1)
                {
                    x--;
                    continue;
                }

                mines.Add(new CreateMineAction(pos));
            }

            var keys = mines.SelectMany(r => r.ChangedPositions());
            var numberedCells = new List<IAction>();
            foreach (var minePos in keys)
            {
                for (var x1 = -1; x1 < 2; x1++)
                {
                    for (var y1 = -1; y1 < 2; y1++)
                    {
                        var newPos = new Position(minePos.X + x1, minePos.Y + y1);
                        if (newPos != minePos
                            && newPos.IsPositive()
                            && newPos.X < game.Board.XSize
                            && newPos.Y < game.Board.YSize)
                        {
                            numberedCells.Add(new IncreaseNumberedCellAction(newPos));
                        }
                    }
                }
            }

            mines.AddRange(numberedCells);

            return mines;
        }
    }
}