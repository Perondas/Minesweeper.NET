using Minesweeper.Logic.Game;

namespace Minesweeper.Logic.Visitor
{
    public interface ICellVisitor<T>
    {
        T Visit(EmptyCell cell);

        T Visit(CellWithMine cell);

        T Visit(NumberedCell cell);
    }
}