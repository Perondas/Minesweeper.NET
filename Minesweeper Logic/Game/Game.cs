namespace Minesweeper.Logic.Game
{
    public class Game
    {
        public Game(int x, int y)
        {
            this.Board = new Board(x, y);
            this.Points = 0;
            this.HasStarted = false;
        }

        public int Points { get; private set; }

        public bool HasStarted { get; private set; }

        public Board Board { get; private set; }

    }
}