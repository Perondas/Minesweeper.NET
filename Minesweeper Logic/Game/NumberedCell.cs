namespace Minesweeper.Logic.Game
{
    public class NumberedCell : Cell
    {
        public NumberedCell(int num)
        {
            this.Num = num;
        }

        public int Num { get; private set; }
    }
}