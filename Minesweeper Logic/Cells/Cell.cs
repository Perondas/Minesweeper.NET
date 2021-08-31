using Minesweeper.Logic.Visitor;

namespace Minesweeper.Logic.Game
{
    public abstract class Cell : ICanBeOpened, ICellVisitable<bool>, ICellVisitable<uint>
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

        public abstract bool Accept(ICellVisitor<bool> visitor);
        public abstract uint Accept(ICellVisitor<uint> visitor);
    }
}