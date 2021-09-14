using Minesweeper.Common.Data;
using Minesweeper.Logic.Visitor;
using System.Collections.Generic;

namespace Minesweeper.Logic.Actions
{
    public interface IAction : IActionVisitable
    {
        Game.Game Execute(Game.Game game);

        IEnumerable<Position> ChangedPositions();
    }
}