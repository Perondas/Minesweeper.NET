using Minesweeper.View.EventArgs;
using Minesweeper.ViewModel.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Minesweeper.View.UserControls
{
    /// <summary>
    /// Interaction logic for Cell.xaml
    /// </summary>
    public partial class Cell : UserControl
    {
        public Cell()
        {
            InitializeComponent();
        }

        public delegate void CellClickedEventHandler(object sender, CellClickedEventArgs e);

        public static readonly DependencyProperty CellVmDependency =
            DependencyProperty.Register("CellVm", typeof(CellVm), typeof(Cell));

        public static readonly RoutedEvent RightClickEvent =
            EventManager.RegisterRoutedEvent("RightClick", RoutingStrategy.Bubble,
                typeof(CellClickedEventHandler), typeof(Cell));

        public static readonly RoutedEvent LeftClickEvent =
            EventManager.RegisterRoutedEvent("LeftClick", RoutingStrategy.Bubble,
                typeof(CellClickedEventHandler), typeof(Cell));

        public event CellClickedEventHandler RightClick
        {
            add => AddHandler(RightClickEvent, value);
            remove => RemoveHandler(RightClickEvent, value);
        }

        public event CellClickedEventHandler LeftClick
        {
            add => AddHandler(LeftClickEvent, value);
            remove => RemoveHandler(LeftClickEvent, value);
        }

        public CellVm CellVm
        {
            get => this.GetValue(CellVmDependency) as CellVm;
            set => this.SetValue(CellVmDependency, value);
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            var args = new CellClickedEventArgs(LeftClickEvent, this.CellVm.Position);
            this.RaiseEvent(args);
        }

        private void Button_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            var args = new CellClickedEventArgs(RightClickEvent, this.CellVm.Position);
            this.RaiseEvent(args);
        }
    }
}
