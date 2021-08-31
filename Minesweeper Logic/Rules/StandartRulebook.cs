using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Data;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Rules
{
    public class StandartRulebook :IRulebook
    {
        public StandartRulebook()
        {
            
        }

        public Game.Game CreateGame(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public GameState GameStatus(Game.Game game)
        {
            throw new System.NotImplementedException();
        }

        public IAction ExecuteOnCell(Game.Game game, Position pos)
        {
            throw new System.NotImplementedException();
        }
    }
}