namespace Minesweeper.Logic.Game
{
    public abstract class Cell : ICanBeOpened
    {
        public Cell()
        {
            
        }

        public bool IsOpen
        {
            get;
            private set;
        }
    }
}