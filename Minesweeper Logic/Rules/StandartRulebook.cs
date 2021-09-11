using System.Collections.Generic;
using Minesweeper.Common.Data;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Rules
{
    public class StandartRulebook : IRulebook
    {
        private GameCreationRule gameCreationRule;
        private GameStateRule gameStateRule;
        private OpenCellRule openCellRule;
        private GameStartRule gameStartRule;
        private CellFlaggingRule cellFlaggingRule;


        public StandartRulebook()
        {
            this.gameCreationRule = new GameCreationRule();
            this.gameStateRule = new GameStateRule();
            this.openCellRule = new OpenCellRule();
            this.gameStartRule = new GameStartRule();
            this.cellFlaggingRule = new CellFlaggingRule();
        }

        public Game.Game CreateGame(GameSettings settings)
        {
            return this.gameCreationRule.CreateGame(settings);
        }

        public Game.Game StartGame(Game.Game game, Position initialPosition, int mineCount)
        {
            return this.gameStartRule.StartGame(game, initialPosition, mineCount);
        }

        public GameState GameStatus(Game.Game game)
        {
            return this.gameStateRule.GetGameState(game);
        }

        public IEnumerable<IAction> OpenCell(Game.Game game, Position pos)
        {
            return this.openCellRule.OpenCell(game, pos);
        }

        public IEnumerable<IAction> FlagCell(Game.Game game, Position pos)
        {
            return this.cellFlaggingRule.FlagCell(game, pos);
        }
    }
}