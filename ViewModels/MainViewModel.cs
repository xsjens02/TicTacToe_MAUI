using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GameXO_MAUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string firstName;

        [ObservableProperty]
        private string secondName;

        public MainViewModel()
        {
            FirstName = "";
            SecondName = "";
        }

        [RelayCommand]
        private async Task GoToGame() {
            Dictionary<string, object> parameters = new()
            {
                { "player1", FirstName },
                { "player2", SecondName },
                { "initTurnDisplay", $"Start the Game {FirstName}" }
            };
            await Shell.Current.GoToAsync("//GamePage", parameters);
        }
    }
}
