using System.Windows;
using Minesweeper.Common.Data;
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
            this.GameVm = new GameVm(new GameSettings(20, 20, 10));
            this.GameVm.Start();
            InitializeComponent();
        }
    }
}
