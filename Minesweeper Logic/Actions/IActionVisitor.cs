namespace Minesweeper.Logic.Actions
{
    public interface IActionVisitor<T>
    {
        T Accept(OpenCellAction action);
    }
}