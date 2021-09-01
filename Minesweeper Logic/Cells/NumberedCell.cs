using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Game
{
    public class NumberedCell : Cell
    {
        public NumberedCell(int num)
        {
            this.Num = num;
        }

        public int Num { get; set; }

        public override T Accept<T>(ICellVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}