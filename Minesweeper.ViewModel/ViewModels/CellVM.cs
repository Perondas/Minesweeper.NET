using System.ComponentModel;
using System.Runtime.CompilerServices;
using Minesweeper.Common.Data;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Visitor;
using Minesweeper.ViewModel.Annotations;

namespace Minesweeper.ViewModel.ViewModels
{
    public class CellVm : INotifyPropertyChanged, ICellVisitor<int?>
    {
        private Position pos;

        private Cell cell;

        public CellVm(Position pos, Cell cell)
        {
            this.pos = pos;
            this.cell = cell;
            this.Num = cell.Accept(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsOpen 
        {
            get => this.cell.IsOpen;
            set
            {
                this.cell.IsOpen = value;
                this.OnPropertyChanged();
            }
        }

        public Position Position => this.pos;

        public Cell Cell => this.cell;

        public int? Num
        {
            get;
            private set;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public int? Visit(EmptyCell _)
        {
            return null;
        }

        public int? Visit(CellWithMine _)
        {
            return null;
        }

        public int? Visit(NumberedCell visitedCell)
        {
            return visitedCell.Num;
        }
    }
}