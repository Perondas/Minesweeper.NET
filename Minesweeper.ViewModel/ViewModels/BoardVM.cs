using Minesweeper.Common.Data;
using Minesweeper.Logic.Game;
using Minesweeper.ViewModel.Annotations;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Minesweeper.ViewModel.ViewModels
{
    public class BoardVm : INotifyPropertyChanged
    {
        private Board board;
        private ObservableCollection<CellVm> cells;

        public BoardVm(Board board)
        {
            this.board = board;
            this.Cells = new ObservableCollection<CellVm>();
            foreach (var pair in board.Cells)
            {
                this.Cells.Add(new CellVm(pair.Key, pair.Value));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<CellVm> Cells
        {
            get
            {
                return this.cells;
            }
            private set
            {
                this.cells = value;
                this.OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void UpdateCell(Position pos)
        {
            this.board.Cells.TryGetValue(pos, out var cell);
            this.cells.Remove(this.Cells.First(c => c.Position == pos));
            this.cells.Add(new CellVm(pos, cell));
        }
    }
}