using Minesweeper.Common.Data;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Visitor;
using Minesweeper.ViewModel.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Minesweeper.ViewModel.ViewModels
{
    public class CellVm : INotifyPropertyChanged, ICellVisitor<int?>
    {
        public CellVm(Position pos, Cell cell)
        {
            this.Position = pos;
            this.Cell = cell;
            this.Num = cell.Accept(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsOpen => this.Cell.IsOpen;

        public bool IsNotFlagged => !this.Cell.IsFlagged;

        public Position Position { get; }

        public Cell Cell { get; }

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

        public void Update()
        {
            this.OnPropertyChanged(nameof(this.IsNotFlagged));
            this.OnPropertyChanged(nameof(this.IsOpen));
        }
    }
}