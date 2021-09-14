using Minesweeper.Common.Data;
using Minesweeper.View.Windows;
using Minesweeper.ViewModel.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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

        private void ButtonCustom_OnClick(object sender, RoutedEventArgs e)
        {
            var popup = new GameStartDialogue();
            var result = popup.Display();
            if (result.HasValue)
            {
                var game = new GamePage(new GameVm(result.Value));
                NavigationService.Navigate(game);
            }
        }

        private void Button10X10_OnClick(object sender, RoutedEventArgs e)
        {
            var game = new GamePage(new GameVm(new GameSettings(10, 10, 10)));
            NavigationService.Navigate(game);
        }
    }
}
