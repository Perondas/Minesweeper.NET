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
using System.Windows.Shapes;
using Minesweeper.Common.Data;

namespace Minesweeper.View.Windows
{
    /// <summary>
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Window
    {
        private string hCells;
        private string vCells;
        private string mines;

        public StartMenu()
        {
            this.hCells = "";
            this.vCells = "";
            this.mines = "";
            InitializeComponent();
        }

        public GameSettings? Display ()
        {
            this.ShowDialog();

            return !int.TryParse(this.hCells, out var hResult)
                ? null
                : !int.TryParse(this.vCells, out var vResult)
                    ? null
                    : !int.TryParse(this.mines, out var mResult)
                        ? (GameSettings?) null
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
