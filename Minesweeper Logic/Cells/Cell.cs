using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Game
{
    public abstract class Cell : ICanBeOpened, ICellVisitable
    {
        public Cell()
        {
            this.IsOpen = false;
            this.IsFlagged = false;
        }

        public bool IsOpen
        {
            get;
            set;
        }

        public bool IsFlagged
        {
            get;
            set;
        }

        public void Open()
        {
            this.IsOpen = true;
        }

        public void Flag()
        {
            this.IsFlagged = !this.IsFlagged;
        }

        public abstract T Accept<T>(ICellVisitor<T> visitor);
    }
}