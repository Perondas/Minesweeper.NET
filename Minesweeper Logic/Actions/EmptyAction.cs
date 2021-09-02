namespace Minesweeper.Logic.Actions
{
    public class EmptyAction : IAction
    {
        public T Visit<T>(IActionVisitor<T> visitor)
        {
            return visitor.Accept(this);
        }

        public Game.Game Execute(Game.Game game)
        {
            return game;
        }
    }
}