using Minesweeper.Common.Data;

namespace Minesweeper.Logic.Game
{
    public class Game
    {
        public Game(GameSettings settings)
        {
            MineCount = settings.MineCount;
            this.Board = new Board(settings.XSize, settings.YSize);
            this.Points = 0;
            this.HasStarted = false;
        }

        public int Points { get; private set; }

        public bool HasStarted { get; private set; }

        public Board Board { get; private set; }

        public int MineCount { get; private set; }
    }
}