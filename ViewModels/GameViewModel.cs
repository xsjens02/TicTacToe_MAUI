using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace GameXO_MAUI.ViewModels
{
    [QueryProperty(nameof(Player1), "player1")]
    [QueryProperty(nameof(Player2), "player2")]
    [QueryProperty(nameof(TurnDisplay), "initTurnDisplay")]
    public partial class GameViewModel : ObservableObject 
    {
        private int cnt;

        [ObservableProperty]
        private string player1;

        [ObservableProperty]
        private string player2;

        [ObservableProperty]
        private string turnDisplay;

        [ObservableProperty]
        private ObservableCollection<string> board;

        public GameViewModel() 
        {
            cnt = 0;
            Player1 = "";
            Player2 = "";
            TurnDisplay = "";
            Board = new();
            Reset();
        }

        [RelayCommand]
        private void Mark(string position)
        {
            int index = int.Parse(position);
            if (Board[index] == " ")
            {
                string mark = cnt % 2 == 0 ? "X" : "O";
                Board[index] = mark;
                OnPropertyChanged(nameof(Board));

                cnt++;
                TurnDisplay = $"Your turn {(mark == "X" ? Player2 : Player1)}";
            }
        }

        [RelayCommand]
        private void Reset()
        {
            Board.Clear();
            for (int i = 0; i < 9; i++)
                Board.Add(" ");
            OnPropertyChanged(nameof(Board));

            cnt = 0;
            TurnDisplay = $"Start the Game {Player1}";
        }

        [RelayCommand]
        private async Task GoToScore() => await Shell.Current.GoToAsync($"//HighScorePage?bestPlayer={Player1}");

        [RelayCommand]
        private async Task GoBack()
        {
            Reset();
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
