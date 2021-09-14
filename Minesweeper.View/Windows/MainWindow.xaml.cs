using Minesweeper.View.Pages;
using System.Windows;

namespace Minesweeper.View.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var page = new MainMenu();

            InitializeComponent();
            this.Frame.Navigate(page);
        }
    }
}
