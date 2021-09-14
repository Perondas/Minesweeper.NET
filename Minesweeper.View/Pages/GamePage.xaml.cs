using Minesweeper.View.EventArgs;
using Minesweeper.ViewModel.ViewModels;
using System.Windows.Controls;

namespace Minesweeper.View.Pages
{
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        private bool hasStarted;

        public GameVm GameVm
        {
            get;
            private set;
        }

        public GamePage(GameVm game)
        {
            this.GameVm = game;
            this.hasStarted = false;
            InitializeComponent();
        }

        private void Cell_OnRightClick(object sender, CellClickedEventArgs e)
        {
            if (!hasStarted)
            {
                return;
            }

            this.GameVm.FlagCell(e.Position);
        }

        private void Cell_OnLeftClick(object sender, CellClickedEventArgs e)
        {
            if (!hasStarted)
            {
                this.hasStarted = true;
                this.GameVm.Start(e.Position);
            }

            this.GameVm.OpenCell(e.Position);
        }
    }
}
