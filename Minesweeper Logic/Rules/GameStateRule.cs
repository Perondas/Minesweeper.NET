using System;
using System.Linq;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Rules
{
    public class GameStateRule : ICellVisitor<bool>
    {
        public GameState GetGameState(Game.Game game)
        {
            return game.Board.Cells.Values.Any(c => c.Accept(this) && c.IsOpen)
                ? GameState.Lost
                : game.Board.Cells.Values.Where(c => c.Accept(this)).All(m => m.IsFlagged)
                    ? game.Board.Cells.Values.Where(c => !c.Accept(this)).All(c => c.IsOpen && !c.IsFlagged)
                        ? GameState.Won
                        : GameState.Ongoing
                    : GameState.Ongoing;
        }

        public bool Visit(EmptyCell _)
        {
            return false;
        }

        public bool Visit(CellWithMine _)
        {
            return true;
        }

        public bool Visit(NumberedCell _)
        {
            return false;
        }
    }
}