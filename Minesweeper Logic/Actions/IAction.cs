namespace Minesweeper.Logic.Actions
{
    public interface IAction : IActionVisitable
    {
        Game.Game Execute(Minesweeper.Logic.Game.Game game);
    }
}