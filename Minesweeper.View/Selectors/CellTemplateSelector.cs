using System;
using System.Windows;
using System.Windows.Controls;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Visitor;
using Minesweeper.ViewModel.ViewModels;

namespace Minesweeper.View.Selectors
{
    public class CellTemplateSelector : DataTemplateSelector, ICellVisitor<int>
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (!(item is CellVm cell)) throw new ArgumentException($"The item must be of type {typeof(CellVm)}");
            var result = cell.Cell.Accept(this);
            return result == 0
                ? Application.Current.FindResource("EmptyCellDataTemplate") as DataTemplate
                : result == 9
                    ? Application.Current.FindResource("CellWithMineDataTemplate") as DataTemplate
                    : result >= 1 && result <= 8
                        ? Application.Current.FindResource("CellWithNumberDataTemplate") as DataTemplate
                        : throw new ArgumentOutOfRangeException("The number stored in a cell must be between 1 and 8");
        }

        public int Visit(EmptyCell cell)
        {
            return 0;
        }

        public int Visit(CellWithMine cell)
        {
            return 9;
        }

        public int Visit(NumberedCell cell)
        {
            return cell.Num;
        }
    }
}