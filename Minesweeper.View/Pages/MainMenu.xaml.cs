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
using Minesweeper.Logic.Game;
using Minesweeper.View.Windows;
using Minesweeper.ViewModel.ViewModels;

namespace Minesweeper.View.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var popup = new GameStartDialogue();
            var result = popup.Display();
            if (result.HasValue)
            {
                var game = new GamePage(new GameVm(result.Value));
                NavigationService.Navigate(game);
            }
        }
    }
}
