namespace Minesweeper.Logic.Visitor
{
    public interface IActionVisitable
    {
        T Visit<T>(IActionVisitor<T> visitor);
    }
}