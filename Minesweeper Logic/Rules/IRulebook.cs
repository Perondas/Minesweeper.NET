﻿using System;
using System.Collections.Generic;
using Minesweeper.Common.Data;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Rules
{
    public interface IRulebook
    {
        Game.Game CreateGame(GameSettings settings);

        Game.Game StartGame(Game.Game game, Position initialPosition, int mineCount);

        GameState GameStatus(Game.Game game);

        IEnumerable<IAction> OpenCell(Game.Game game, Position pos);

        IEnumerable<IAction> FlagCell(Game.Game game, Position pos);
    }
}