using Minesweeper.Common.Data;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Rules
{
    public class GameCreationRule
    {
        public Game.Game CreateGame(GameSettings settings)
        {
            var game = new Game.Game(settings);

            for (int x = 0; x < settings.XSize; x++)
            {
                for (int y = 0; y < settings.YSize; y++)
                {
                    game.Board.Cells.Add(new Position(x, y), new EmptyCell());
                }
            }

            return game;
        }
    }
}