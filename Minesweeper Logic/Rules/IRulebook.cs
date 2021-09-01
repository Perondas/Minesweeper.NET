using System;
using System.Collections.Generic;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Data;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Rules
{
    public interface IRulebook
    {
        Game.Game CreateGame(uint x, uint y);

        Game.Game StartGame(Game.Game game, Position initialPosition, uint mineCount);

        GameState GameStatus(Game.Game game);

        IEnumerable<IAction> ExecuteOnCell(Game.Game game, Position pos);
    }
}