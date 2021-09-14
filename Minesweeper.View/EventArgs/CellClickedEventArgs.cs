using Minesweeper.Common.Data;
using System.Windows;

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