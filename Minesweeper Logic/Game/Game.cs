namespace Minesweeper.Logic.Game
{
    public class Game
    {
        public uint Points { get; private set; }
        public bool HasStarted { get; private set; }
        public Board Board { get; private set; }
    }
}