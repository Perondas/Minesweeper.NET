using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Data;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Rules
{
    public class StandartRulebook :IRulebook
    {
        private GameCreationRule gameCreationRule;
        private GameStateRule gameStateRule;
        private OpenCellRule openCellRule;


        public StandartRulebook()
        {
            this.gameCreationRule = new GameCreationRule();
            this.gameStateRule = new GameStateRule();
            this.openCellRule = new OpenCellRule();
        }

        public Game.Game CreateGame(uint x, uint y, uint mineCount)
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