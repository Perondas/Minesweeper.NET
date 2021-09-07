using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Minesweeper.Logic.Game;
using Minesweeper.ViewModel.Annotations;

namespace Minesweeper.ViewModel.ViewModels
{
    public class BoardVm : INotifyPropertyChanged
    {
        private Board board;

        public BoardVm(Board board)
        {
            this.board = board;
            this.Cells = new ObservableCollection<CellVm>();
            foreach (var pos in board.Cells.Keys)
            {
                board.Cells.TryGetValue(pos, out var cell);
                this.Cells.Add(new CellVm(pos, cell));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<CellVm> Cells
        {
            get;
            private set;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}