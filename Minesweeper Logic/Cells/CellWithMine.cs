using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Game
{
    public class CellWithMine : Cell
    {
        public override T Accept<T>(ICellVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}