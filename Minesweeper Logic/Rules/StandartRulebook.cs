using System.Collections.Generic;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Data;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Rules
{
    public class StandartRulebook : IRulebook
    {
        private GameCreationRule gameCreationRule;
        private GameStateRule gameStateRule;
        private OpenCellRule openCellRule;
        private GameStartRule gameStartRule;


        public StandartRulebook()
        {
            this.gameCreationRule = new GameCreationRule();
            this.gameStateRule = new GameStateRule();
            this.openCellRule = new OpenCellRule();
            this.gameStartRule = new GameStartRule();
        }

        public Game.Game CreateGame(int x, int y)
        {
            return this.gameCreationRule.CreateGame(x, y);
        }

        public Game.Game StartGame(Game.Game game, Position initialPosition, uint mineCount)
        {
            return this.gameStartRule.StartGame(game, initialPosition, mineCount);
        }

        public GameState GameStatus(Game.Game game)
        {
            return this.gameStateRule.GetGameState(game);
        }

        public IEnumerable<IAction> ExecuteOnCell(Game.Game game, Position pos)
        {
            return this.openCellRule.OpenCell(game, pos);
        }
    }
}