using Minesweeper.Common.Data;
using Minesweeper.Logic.Actions;
using Minesweeper.Logic.Game;
using Minesweeper.Logic.Rules;
using Minesweeper.ViewModel.Annotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

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

        public void Start(Position pos)
        {
            var actions = this.book.StartGame(this.game, pos, this.game.MineCount);
            this.ExecuteActions(actions);
        }

        public BoardVm Board
        {
            get
            {
                return this.board;
            }
            set
            {
                this.board = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void FlagCell(Position position)
        {
            var actions = this.book.FlagCell(this.game, position);
            this.ExecuteActions(actions);
        }

        private void ExecuteActions(IEnumerable<IAction> actions)
        {
            foreach (var action in actions)
            {
                action.Execute(this.game);
            }

            var changedPositions = actions.SelectMany(a => a.ChangedPositions()).Distinct();

            foreach (var changes in changedPositions)
            {
                this.board.UpdateCell(changes);
            }
        }

        public void OpenCell(Position position)
        {
            var actions = this.book.OpenCell(this.game, position);
            this.ExecuteActions(actions);
        }
    }
}