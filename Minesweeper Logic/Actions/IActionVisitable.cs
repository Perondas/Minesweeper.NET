using System.Runtime.InteropServices.ComTypes;

namespace Minesweeper.Logic.Actions
{
    public interface IActionVisitable
    {
        T Visit<T>(IActionVisitor<T> visitor);
    }
}