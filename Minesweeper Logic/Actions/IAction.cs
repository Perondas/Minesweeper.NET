namespace Minesweeper.Logic.Actions
{
    public interface IAction
    {
        Game.Game Execute(Minesweeper.Logic.Game.Game game);
    }
}