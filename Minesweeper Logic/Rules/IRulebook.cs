using System;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Data;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Rules
{
    public interface IRulebook
    {
        Game.Game CreateGame(uint x, uint y, uint mineCount);

        GameState GameStatus(Game.Game game);

        IAction ExecuteOnCell(Game.Game game, Position pos);
    }
}