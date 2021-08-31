namespace Minesweeper.Logic.Visitor
{
    public interface ICellVisitable<T>
    {
        T Accept(ICellVisitor<T> visitor);
    }
}