using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Data;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Rules
{
    public interface IRulebook
    {
        Game.Game CreateGame(int x, int y);

        GameState GameStatus(Game.Game game);

        IAction ExecuteOnCell(Game.Game game, Position pos);
    }
}