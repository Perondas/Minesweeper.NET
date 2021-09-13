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
using Minesweeper.Common.Data;
using Minesweeper.View.EventArgs;
using Minesweeper.ViewModel.ViewModels;

namespace Minesweeper.View.Pages
{
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        public GameVm GameVm
        {
            get;
            private set;
        }

        public GamePage(GameVm game)
        {
            this.GameVm = game;
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
