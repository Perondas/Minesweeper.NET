using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Minesweeper.ViewModel.ViewModels;

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

        public static readonly DependencyProperty CellVmDependency =
            DependencyProperty.Register("CellVm", typeof(CellVm), typeof(Cell));

        public CellVm CellVm
        {
            get => this.GetValue(CellVmDependency) as CellVm;
            set => this.SetValue(CellVmDependency, value);
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            this.CellVm.Open();
        }

        private void Button_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.CellVm.Flag();
        }
    }
}
