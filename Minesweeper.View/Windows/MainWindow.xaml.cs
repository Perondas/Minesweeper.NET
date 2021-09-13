using System;
using System.Windows;
using Minesweeper.Common.Data;
using Minesweeper.View.EventArgs;
using Minesweeper.View.Pages;
using Minesweeper.ViewModel.ViewModels;

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
