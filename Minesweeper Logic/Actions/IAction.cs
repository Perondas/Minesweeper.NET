using System.Collections.Generic;
using Minesweeper.Common.Data;

namespace Minesweeper.Logic.Actions
{
    public interface IAction : IActionVisitable
    {
        Game.Game Execute(Game.Game game);

        IEnumerable<Position> ChangedPositions();
    }
}