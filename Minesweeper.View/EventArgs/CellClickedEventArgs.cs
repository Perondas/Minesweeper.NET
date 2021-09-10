using System.Windows;
using Minesweeper.Common.Data;

namespace Minesweeper.View.EventArgs
{
    public class CellClickedEventArgs : RoutedEventArgs
    {
        public CellClickedEventArgs(RoutedEvent routedEvent, Position position) : base(routedEvent)
        {
            Position = position;
        }

        public Position Position { get; private set; }
    }
}