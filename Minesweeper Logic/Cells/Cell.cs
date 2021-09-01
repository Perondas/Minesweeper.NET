using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Game
{
    public abstract class Cell : ICanBeOpened, ICellVisitable
    {
        public Cell()
        {
            this.IsOpen = false;
        }

        public bool IsOpen
        {
            get;
            private set;
        }


        public void Open()
        {
            this.IsOpen = true;
        }

        public abstract T Accept<T>(ICellVisitor<T> visitor);
    }
}