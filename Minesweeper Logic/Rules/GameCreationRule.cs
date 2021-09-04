using System;
using Minesweeper.Common.Data;

namespace Minesweeper.Logic.Rules
{
    public class GameCreationRule
    {
        public Game.Game CreateGame(GameSettings settings)
        {
            return new Game.Game(settings);
        }
    }
}