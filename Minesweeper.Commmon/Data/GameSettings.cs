namespace Minesweeper.Common.Data
{
    public struct GameSettings
    {
        public GameSettings(int xSize, int ySize, int mineCount)
        {
            XSize = xSize;
            YSize = ySize;
            MineCount = mineCount;
        }

        public int XSize { get; private set; }
        public int YSize { get; private set; }
        public int MineCount { get; private set; }

    }
}