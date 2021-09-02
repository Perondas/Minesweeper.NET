using System.ComponentModel;
using System.Runtime.CompilerServices;
using Minesweeper.Logic.Game;
using Minesweeper.ViewModel.Annotations;

namespace Minesweeper.ViewModel.ViewModels
{
    public class GameVM : INotifyPropertyChanged
    {
        private Game game;
        private BoardVM board;

        public GameVM(Game game)
        {
            this.game = game;
            this.board = new BoardVM(game.Board);
        }

        public BoardVM Board => this.board;

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}