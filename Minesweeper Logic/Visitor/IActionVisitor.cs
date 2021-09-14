using Minesweeper.Logic.Actions;

namespace Minesweeper.Logic.Visitor
{
    public interface IActionVisitor<T>
    {
        T Accept(OpenCellAction action);
        T Accept(FlagCellAction action);
        T Accept(DeFlagCellAction action);
        T Accept(EmptyAction action);

        T Accept(CreateMineAction action);

        T Accept(IncreaseNumberedCellAction action);
    }
}