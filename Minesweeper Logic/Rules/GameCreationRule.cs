using System;

namespace Minesweeper.Logic.Rules
{
    public class GameCreationRule
    {
        public Game.Game CreateGame(int x, int y)
        {
            return new Game.Game(x, y);
        }
    }
}