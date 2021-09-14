using Minesweeper.Common.Data;
using System.Windows;

namespace Minesweeper.View.Windows
{
    /// <summary>
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class GameStartDialogue : Window
    {
        private string hCells;
        private string vCells;
        private string mines;

        public GameStartDialogue()
        {
            this.hCells = "";
            this.vCells = "";
            this.mines = "";
            InitializeComponent();
        }

        public GameSettings? Display()
        {
            this.ShowDialog();

            return !int.TryParse(this.hCells, out var hResult)
                ? null
                : !int.TryParse(this.vCells, out var vResult)
                    ? null
                    : !int.TryParse(this.mines, out var mResult)
                        ? (GameSettings?)null
                        : new GameSettings(hResult, vResult, mResult);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.hCells = this.HCells.Text;
            this.vCells = this.VCells.Text;
            this.mines = this.Mines.Text;
            this.Close();
        }
    }
}
