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
            this.GameVm = new GameVm(new GameSettings(5, 5, 10));
            this.GameVm.Start();
            InitializeComponent();
        }

        private void Cell_OnRightClick(object sender, CellClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Cell_OnLeftClick(object sender, CellClickedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
