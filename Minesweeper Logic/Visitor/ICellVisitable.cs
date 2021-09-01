namespace Minesweeper.Logic.Visitor
{
    public interface ICellVisitable
    {
        T Accept<T>(ICellVisitor<T> visitor);
    }
}