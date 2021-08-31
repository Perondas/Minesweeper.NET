using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Game
{
    public class CellWithMine : Cell
    {
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