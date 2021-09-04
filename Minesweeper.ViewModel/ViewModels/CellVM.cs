using System.ComponentModel;
using System.Runtime.CompilerServices;
using Minesweeper.Common.Data;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Game;
using Minesweeper.ViewModel.Annotations;

namespace Minesweeper.ViewModel.ViewModels
{
    public class CellVM : INotifyPropertyChanged
    {
        private Position pos;

        private Cell cell;

        public CellVM(Position pos, Cell cell)
        {
            this.pos = pos;
            this.cell = cell;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsOpen 
        {
            get
            {
                return this.cell.IsOpen;
            }
            set
            {
                this.cell.IsOpen = value;
                this.OnPropertyChanged();
            }
        }

        public Position position => this.position;

        public Cell Cell => this.cell;


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}