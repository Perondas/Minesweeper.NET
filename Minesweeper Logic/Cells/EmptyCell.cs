using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Game
{
    public class EmptyCell : Cell
    {
        public override T Accept<T>(ICellVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}