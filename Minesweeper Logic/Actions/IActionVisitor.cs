namespace Minesweeper.Logic.Actions
{
    public interface IActionVisitor<T>
    {
        T Accept(OpenCellAction action);
        T Accept(FlagCellAction action);
        T Accept(DeFlagCellAction action);
        T Accept(EmptyAction action);
    }
}