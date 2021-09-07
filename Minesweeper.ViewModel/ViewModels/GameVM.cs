using System.ComponentModel;
using System.Runtime.CompilerServices;
using Minesweeper.Common.Data;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Rules;
using Minesweeper.ViewModel.Annotations;

namespace Minesweeper.ViewModel.ViewModels
{
    public class GameVm : INotifyPropertyChanged
    {
        private Game game;
        private BoardVm board;
        private IRulebook book;

        public GameVm(GameSettings settings)
        {
            this.book = new StandartRulebook();
            this.game = this.book.CreateGame(settings);
            this.board = new BoardVm(game.Board);
        }

        public void Start()
        {
            this.book.StartGame(this.game, new Position(1, 1), this.game.MineCount);
            this.board = new BoardVm(this.game.Board);
        }

        public BoardVm Board => this.board;

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}