using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Game
{
    public class NumberedCell : Cell
    {
        public NumberedCell(int num)
        {
            this.Num = num;
        }

        public int Num { get; private set; }

        public override bool Accept(ICellVisitor<bool> visitor)
        {
            return visitor.Visit(this);
        }

        public override uint Accept(ICellVisitor<uint> visitor)
        {
            return visitor.Visit(this);
        }
    }
}