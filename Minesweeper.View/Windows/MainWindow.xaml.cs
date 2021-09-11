using System;
using System.Windows;
using Minesweeper.Common.Data;
using Minesweeper.View.EventArgs;
using Minesweeper.ViewModel.ViewModels;

namespace Minesweeper.View.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameVm GameVm
        {
            get;
            private set;
        }

        public MainWindow()
        {
            this.GameVm = new GameVm(new GameSettings(10, 10, 5));
            this.GameVm.Start();
            InitializeComponent();
        }

        private void Cell_OnRightClick(object sender, CellClickedEventArgs e)
        {
            this.GameVm.FlagCell(e.Position);
        }

        private void Cell_OnLeftClick(object sender, CellClickedEventArgs e)
        {
            this.GameVm.OpenCell(e.Position);
        }
    }
}
