using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Minesweeper.Logic.Game;
using Minesweeper.ViewModel.Annotations;

namespace Minesweeper.ViewModel.ViewModels
{
    public class BoardVM : INotifyPropertyChanged
    {
        private Board board;

        public BoardVM(Board board)
        {
            this.board = board;
            this.Cells = new ObservableCollection<CellVM>();
            foreach (var pos in board.Cells.Keys)
            {
                board.Cells.TryGetValue(pos, out var cell);
                this.Cells.Add(new CellVM(pos, cell));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<CellVM> Cells;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}